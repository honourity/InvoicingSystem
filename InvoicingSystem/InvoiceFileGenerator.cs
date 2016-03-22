using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicingSystem
{
  public class InvoiceFileGenerator
  {
    public void GeneratePDF(invoiceheader invoice)
    {
      using (var entities = new InvoiceSystemEntities())
      {
        var me = entities.clients.Where(item => item.isme == true).First();
        var client = invoice.client;

        string templateText = System.IO.File.ReadAllText(@"Templates\template_base.html");
        templateText = templateText.Replace("<%name%>", me.clientname);
        templateText = templateText.Replace("<%address%>", me.address);
        templateText = templateText.Replace("<%phonenumber%>", me.phonenumber);
        templateText = templateText.Replace("<%abn%>", me.abn);
        templateText = templateText.Replace("<%email%>", me.email);
        templateText = templateText.Replace("<%clientname%>", client.clientname);
        templateText = templateText.Replace("<%invoicedate%>", invoice.datecreated.ToString("dd/MM/yyyy"));
        templateText = templateText.Replace("<%invoicenumber%>", invoice.number.ToString());
        templateText = templateText.Replace("<%invoicelines%>", ConvertInvoiceLinesToTableHTML(invoice));
        templateText = templateText.Replace("<%totalextax%>", (invoice.invoicelines.Sum(item => (item.hours * item.project.hourlyrate))).ToString());
        templateText = templateText.Replace("<%tax%>", client.taxrate.ToString());
        templateText = templateText.Replace("<%totalinctax%>", ((invoice.invoicelines.Sum(item => (item.hours * item.project.hourlyrate))) + client.taxrate * (invoice.invoicelines.Sum(item => (item.hours * item.project.hourlyrate)))).ToString());

        File.WriteAllText("output.html", templateText);
        string invoiceFile;

        if (invoice.invoicelines.Count > 0)
        {
          invoiceFile = "TaxInvoice" + client.clientname.Split(' ').First().ToString() + invoice.invoicelines.Last().datecompleted.ToString("MMMM") + ".pdf";
        }
        else
        {
          invoiceFile = "TaxInvoice" + client.clientname.Split(' ').First().ToString() + "EMPTY" + ".pdf";
        }


        ProcessStartInfo psi = new ProcessStartInfo();
        psi.Arguments = "output.html " + invoiceFile;
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;
        psi.FileName = @"Plugins\wkhtmltopdf.exe";
        Process.Start(psi);
        Process.Start("explorer.exe", @".");
      }
    }

    private static string ConvertInvoiceLinesToTableHTML(invoiceheader invoiceheader)
    {
      StringBuilder templateString = new StringBuilder();
      foreach (invoiceline line in invoiceheader.invoicelines.OrderBy(item => item.number))
      {
        templateString.Append("<tr style='page-break-inside:avoid;height:.2in'>\n");

        templateString.Append("<td width=105 style='width:78.85pt;border:solid silver 1.0pt;border-top:none;background:white;padding:2.15pt 5.75pt 2.15pt 5.75pt;height:.2in'><p class=MsoNormal><span style='font-family:\"Calibri\",\"sans-serif\"'>").Append(line.datecompleted.ToString("dd/MM/yyyy")).Append("</span></p></td>\n");
        templateString.Append("<td width=330 style='width:247.5pt;border-top:none;border-left:none;border-bottom:solid silver 1.0pt;border-right:solid silver 1.0pt;background:white;padding:2.15pt 5.75pt 2.15pt 5.75pt;height:.2in'><p class=MsoNormal><span style='font-family:\"Calibri\",\"sans-serif\"'>").Append(line.description).Append("</span></p></td>\n");
        templateString.Append("<td width=137 style='width:102.45pt;border-top:none;border-left:none;border-bottom:solid silver 1.0pt;border-right:solid silver 1.0pt;background:white;padding:2.15pt 5.75pt 2.15pt 5.75pt;height:.2in'><p class=MsoNormal align=center style='text-align:center'><spanstyle='font-family:\"Calibri\",\"sans-serif\"'>").Append(line.project.name).Append("</span></p></td>\n");
        templateString.Append("<td width=75 style='width:56.05pt;border-top:none;border-left:none;border-bottom:solid silver 1.0pt;border-right:solid silver 1.0pt;background:white;padding:2.15pt 5.75pt 2.15pt 5.75pt;height:.2in'><p class=MsoNormal align=center style='text-align:center'><spanstyle='font-family:\"Calibri\",\"sans-serif\"'>").Append(line.project.hourlyrate).Append("</span></p></td>\n");
        templateString.Append("<td width=82 style='width:61.8pt;border-top:none;border-left:none;border-bottom:solid silver 1.0pt;border-right:solid silver 1.0pt;background:white;padding:2.15pt .15in 2.15pt .15in;height:.2in'><p class=MsoNormal align=center style='text-align:center'><spanstyle='font-family:\"Calibri\",\"sans-serif\"'>").Append(line.hours).Append("</span></p></td>\n");
        templateString.Append("<td width=93 style='width:70.05pt;border-top:none;border-left:none;border-bottom:solid silver 1.0pt;border-right:solid silver 1.0pt;background:white;padding:2.15pt .15in 2.15pt .15in;height:.2in'><p class=MsoNormal><span style='font-family:\"Calibri\",\"sans-serif\"'>$").Append(line.hours * line.project.hourlyrate).Append("</span></p></td>\n");

        templateString.Append("</tr>\n");
      }
      return templateString.ToString();
    }
  }
}
