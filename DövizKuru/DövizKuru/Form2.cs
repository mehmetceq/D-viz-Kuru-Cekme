using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DövizKuru
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            label18.Text = tarih.ToString();



            //Tanım


            //  string USDDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            //label7.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu);


            //string USDDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Unit").InnerXml;
            //label8.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizbirim);

            //string USDdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            // label9.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi);


            // string USDdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            //label4.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizalis);

            //string USDdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            //label9.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi);


            //----------------------BİRİM UNİT-------------------------------------------
            label8.Text = "1";
            label13.Text = "1";
            label19.Text = "1";
            label24.Text = "1";
            label29.Text = "1";
            label34.Text = "1";
            label39.Text = "1";
            label44.Text = "1";
            label49.Text = "1";
            label54.Text = "1";
            label59.Text = "1";
            label64.Text = "1";
            label69.Text = "1";
            label74.Text = "1";
            label79.Text = "1"; 
            label84.Text = "1";
            label89.Text = "1";
            label94.Text = "1";
            label100.Text = "1";
            label101.Text = "1";














            //----------------------DÖVİZ KODU-------------------------------------------
            string USDDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label7.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu) + "/AUD";
            string USDDovizkodu1 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label12.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu1) + "/DKK";
            string USDDovizkodu2 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label17.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu2) + "/CHF";
            string USDDovizkodu3 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label23.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu3) + "/SEK";
            string USDDovizkodu4 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label28.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu4) + "/JPY";
            string USDDovizkodu5 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label33.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu5) + "/CAD";
            string USDDovizkodu6 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label38.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu6) + "/NOK";
            string USDDovizkodu7 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label43.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu7) + "/SAR";
            string EURDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/@Kod").InnerXml;
            label48.Text = string.Format("{1}", tarih.ToShortDateString(), EURDovizkodu) + "/USD";
            string GBPDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/@Kod").InnerXml;
            label53.Text = string.Format("{1}", tarih.ToShortDateString(), GBPDovizkodu) + "/USD";
            string KWDDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/@Kod").InnerXml;
            label58.Text = string.Format("{1}", tarih.ToShortDateString(), KWDDovizkodu) + "/USD";
            string USDDovizkodu8 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label63.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu8) + "/BGN";
            string USDDovizkodu9 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label68.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu9) + "/RON";
            string USDDovizkodu11 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label73.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu11) + "/RUB";
            string USDDovizkodu12 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label78.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu12) + "/IRR";
            string USDDovizkodu13 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label83.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu13) + "/CNY";
            string USDDovizkodu14 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label88.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu14) + "/PKR";
            string USDDovizkodu115 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label93.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu115) + "/QAR";
            label98.Text = "SDR/USD";
            label99.Text = "SDR/TRY";





            //----------------------DÖVİZ CİNSİ-------------------------------------------

            string USDdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label9.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi);
            string USDdovizcinsi2 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label14.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi2);
            string USDdovizcinsi3 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label20.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi3);
            string USDdovizcins4 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label25.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcins4);
            string USDdovizcinsi5 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label30.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi5);
            string USDdovizcinsi6 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label35.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi6);
            string USDdovizcinsi7 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label40.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi7);
            string USDdovizcinsi8 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label45.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi8);
            string EURdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/Isim").InnerXml;
            label50.Text = string.Format("{1}", tarih.ToShortDateString(), EURdovizcinsi);
            string GBPdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/Isim").InnerXml;
            label55.Text = string.Format("{1}", tarih.ToShortDateString(), GBPdovizcinsi);
            string KWDdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/Isim").InnerXml;
            label60.Text = string.Format("{1}", tarih.ToShortDateString(), KWDdovizcinsi);
            string USDdovizcinsi9 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label65.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi9);
            string USDdovizcinsi10 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label70.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi10);
            string USDdovizcinsi11 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label75.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi11);
            string USDdovizcinsi12 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label80.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi12);
            string USDdovizcinsi13 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label85.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi13);
            string USDdovizcinsi14 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label90.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi14);
            string USDdovizcinsi15 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label95.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi15);

            string XDRdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='XDR']/Isim").InnerXml;
            label102.Text = string.Format("{1}", tarih.ToShortDateString(), XDRdovizcinsi);
            string XDRdovizcinsi2 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='XDR']/Isim").InnerXml;
            label103.Text = string.Format("{1}", tarih.ToShortDateString(), XDRdovizcinsi2);
            string USDdovizcinsi152 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label106.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi152);
            label107.Text = "TÜRK LİRASI";


            //----------------------ÇAPRAZ KUR-------------------------------------------
            string AUDcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/CrossRateUSD").InnerXml;
            label10.Text = string.Format("{1}", tarih.ToShortDateString(), AUDcaprazkur);
            string DKKcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/CrossRateUSD").InnerXml;
            label15.Text = string.Format("{1}", tarih.ToShortDateString(), DKKcaprazkur);
            string CHFcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/CrossRateUSD").InnerXml;
            label21.Text = string.Format("{1}", tarih.ToShortDateString(), CHFcaprazkur);
            string SEKcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/CrossRateUSD").InnerXml;
            label26.Text = string.Format("{1}", tarih.ToShortDateString(), SEKcaprazkur);
            string JPYcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/CrossRateUSD").InnerXml;
            label31.Text = string.Format("{1}", tarih.ToShortDateString(), JPYcaprazkur);
            string CADcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/CrossRateUSD").InnerXml;
            label36.Text = string.Format("{1}", tarih.ToShortDateString(), CADcaprazkur);
            string NOKcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/CrossRateUSD").InnerXml;
            label41.Text = string.Format("{1}", tarih.ToShortDateString(), NOKcaprazkur);
            string SARcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/CrossRateUSD").InnerXml;
            label46.Text = string.Format("{1}", tarih.ToShortDateString(), SARcaprazkur);
            string EURcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/CrossRateOther").InnerXml;
            label51.Text = string.Format("{1}", tarih.ToShortDateString(), EURcaprazkur);
            string GBPcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/CrossRateOther").InnerXml;
            label56.Text = string.Format("{1}", tarih.ToShortDateString(), GBPcaprazkur);
            string KWDcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/CrossRateOther").InnerXml;
            label61.Text = string.Format("{1}", tarih.ToShortDateString(), KWDcaprazkur);
            string BGNcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='BGN']/CrossRateUSD").InnerXml;
            label66.Text = string.Format("{1}", tarih.ToShortDateString(), BGNcaprazkur);
            string RONcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RON']/CrossRateUSD").InnerXml;
            label71.Text = string.Format("{1}", tarih.ToShortDateString(),RONcaprazkur);
            string RUBcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/CrossRateUSD").InnerXml;
            label76.Text = string.Format("{1}", tarih.ToShortDateString(), RUBcaprazkur);
            string IRRcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='IRR']/CrossRateUSD").InnerXml;
            label81.Text = string.Format("{1}", tarih.ToShortDateString(), IRRcaprazkur);
            string CNYcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CNY']/CrossRateUSD").InnerXml;
            label86.Text = string.Format("{1}", tarih.ToShortDateString(), CNYcaprazkur);
            string PKRcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='PKR']/CrossRateUSD").InnerXml;
            label91.Text = string.Format("{1}", tarih.ToShortDateString(), PKRcaprazkur);
            string QARcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='QAR']/CrossRateUSD").InnerXml;
            label96.Text = string.Format("{1}", tarih.ToShortDateString(), QARcaprazkur);
             string XDRcaprazkur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='XDR']/ForexBuying").InnerXml;
            label104.Text = string.Format("{1}", tarih.ToShortDateString(), XDRcaprazkur);
            string XDRcaprazkur2 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='XDR']/CrossRateOther").InnerXml;
            label105.Text = string.Format("{1}", tarih.ToShortDateString(), XDRcaprazkur2);






















            //----------------------DÖVİZ CİNSİ-------------------------------------------

            string AUDdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/Isim").InnerXml;
            label11.Text = string.Format("{1}", tarih.ToShortDateString(), AUDdovizcinsi);
            string DKKdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/Isim").InnerXml;
            label16.Text = string.Format("{1}", tarih.ToShortDateString(), DKKdovizcinsi);
            string CHFdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/Isim").InnerXml;
            label22.Text = string.Format("{1}", tarih.ToShortDateString(), CHFdovizcinsi);
            string SEKdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/Isim").InnerXml;
            label27.Text = string.Format("{1}", tarih.ToShortDateString(), SEKdovizcinsi);
            string JPYdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/Isim").InnerXml;
            label32.Text = string.Format("{1}", tarih.ToShortDateString(), JPYdovizcinsi);
            string CADdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/Isim").InnerXml;
            label37.Text = string.Format("{1}", tarih.ToShortDateString(), CADdovizcinsi);
            string NOKdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/Isim").InnerXml;
            label42.Text = string.Format("{1}", tarih.ToShortDateString(), NOKdovizcinsi);
            string SARdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/Isim").InnerXml;
            label47.Text = string.Format("{1}", tarih.ToShortDateString(), SARdovizcinsi);
            string USDdovizcinsi23 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label52.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi23);
            string USDdovizcinsi24 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label57.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi24);
            string USDdovizcinsi25 = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label62.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi25);
            string BGNdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='BGN']/Isim").InnerXml;
            label67.Text = string.Format("{1}", tarih.ToShortDateString(), BGNdovizcinsi);
            string RONdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RON']/Isim").InnerXml;
            label72.Text = string.Format("{1}", tarih.ToShortDateString(), RONdovizcinsi);
            string RUBdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/Isim").InnerXml;
            label77.Text = string.Format("{1}", tarih.ToShortDateString(), RUBdovizcinsi);
            string IRRdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='IRR']/Isim").InnerXml;
            label82.Text = string.Format("{1}", tarih.ToShortDateString(), IRRdovizcinsi);
            string CNYdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CNY']/Isim").InnerXml;
            label87.Text = string.Format("{1}", tarih.ToShortDateString(), CNYdovizcinsi);
            string PKRdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='PKR']/Isim").InnerXml;
            label92.Text = string.Format("{1}", tarih.ToShortDateString(), PKRdovizcinsi);
            string QARdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='QAR']/Isim").InnerXml;
            label97.Text = string.Format("{1}", tarih.ToShortDateString(), QARdovizcinsi);
















        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); //form2 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz

        }
    }
}
