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
    public partial class Form1 : Form
    {
        public Form1()
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

            ///1)DOLAR İÇİN
            
            //Tanım

            string USDDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/@Kod").InnerXml;
            label1.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizkodu)+"/TRY";

            string USDDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Unit").InnerXml;
            label2.Text = string.Format("{1}", tarih.ToShortDateString(), USDDovizbirim);

            string USDdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            label3.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizcinsi);

            ///Para Ölçümleri
           
            string USDdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            label4.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizalis);

            string USDdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            label5.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizsatis);

            string USDdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteBuying").InnerXml;
            label13.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizefalis);

            string USDdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            label14.Text = string.Format("{1}", tarih.ToShortDateString(), USDdovizefsatis);


            ///2)AUD İÇİN

            string AUDDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/@Kod").InnerXml;
            label15.Text = string.Format("{1}", tarih.ToShortDateString(), AUDDovizkodu) + "/TRY";

            string AUDDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/Unit").InnerXml;
            label16.Text = string.Format("{1}", tarih.ToShortDateString(), AUDDovizbirim);

            string AUDdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/Isim").InnerXml;
            label17.Text = string.Format("{1}", tarih.ToShortDateString(), AUDdovizcinsi);

            string AUDdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/ForexBuying").InnerXml;
            label19.Text = string.Format("{1}", tarih.ToShortDateString(), AUDdovizalis);

            string AUDdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/ForexSelling").InnerXml;
            label20.Text = string.Format("{1}", tarih.ToShortDateString(), AUDdovizsatis);

            string AUDdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/BanknoteBuying").InnerXml;
            label21.Text = string.Format("{1}", tarih.ToShortDateString(), AUDdovizefalis);

            string AUDdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/BanknoteSelling").InnerXml;
            label22.Text = string.Format("{1}", tarih.ToShortDateString(), AUDdovizefsatis);

            //DKK İÇİN

            string DKKDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/@Kod").InnerXml;
            label23.Text = string.Format("{1}", tarih.ToShortDateString(), DKKDovizkodu) + "/TRY";

            string DKKDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/Unit").InnerXml;
            label24.Text = string.Format("{1}", tarih.ToShortDateString(), DKKDovizbirim);

            string DKKdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/Isim").InnerXml;
            label25.Text = string.Format("{1}", tarih.ToShortDateString(), DKKdovizcinsi);

            string DKKdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/ForexBuying").InnerXml;
            label26.Text = string.Format("{1}", tarih.ToShortDateString(), DKKdovizalis);

            string DKKdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/ForexSelling").InnerXml;
            label27.Text = string.Format("{1}", tarih.ToShortDateString(), DKKdovizsatis);

            string DKKdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/BanknoteBuying").InnerXml;
            label28.Text = string.Format("{1}", tarih.ToShortDateString(), DKKdovizefalis);

            string DKKdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/BanknoteSelling").InnerXml;
            label29.Text = string.Format("{1}", tarih.ToShortDateString(), DKKdovizefsatis);

            ///EURO İÇİN
            ///

            string EURDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/@Kod").InnerXml;
            label30.Text = string.Format("{1}", tarih.ToShortDateString(), EURDovizkodu) + "/TRY";

            string EURDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/Unit").InnerXml;
            label31.Text = string.Format("{1}", tarih.ToShortDateString(), EURDovizbirim);

            string EURdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/Isim").InnerXml;
            label32.Text = string.Format("{1}", tarih.ToShortDateString(), EURdovizcinsi);

            string EURdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
            label33.Text = string.Format("{1}", tarih.ToShortDateString(), EURdovizalis);

            string EURdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            label34.Text = string.Format("{1}", tarih.ToShortDateString(), EURdovizsatis);

            string EURdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteBuying").InnerXml;
            label35.Text = string.Format("{1}", tarih.ToShortDateString(), EURdovizefalis);

            string EURdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            label36.Text = string.Format("{1}", tarih.ToShortDateString(), EURdovizefsatis);

            ///GBP İÇİN

            string GBPDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/@Kod").InnerXml;
            label37.Text = string.Format("{1}", tarih.ToShortDateString(), GBPDovizkodu) + "/TRY";

            string GBPDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/Unit").InnerXml;
            label38.Text = string.Format("{1}", tarih.ToShortDateString(), GBPDovizbirim);

            string GBPdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/Isim").InnerXml;
            label39.Text = string.Format("{1}", tarih.ToShortDateString(), GBPdovizcinsi);

            string GBPdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
            label40.Text = string.Format("{1}", tarih.ToShortDateString(), GBPdovizalis);

            string GBPdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            label41.Text = string.Format("{1}", tarih.ToShortDateString(), GBPdovizsatis);

            string GBPdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteBuying").InnerXml;
            label42.Text = string.Format("{1}", tarih.ToShortDateString(), GBPdovizefalis);

            string GBPdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
            label43.Text = string.Format("{1}", tarih.ToShortDateString(), GBPdovizefsatis);

            ///CHF İÇİN

            string CHFDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/@Kod").InnerXml;
            label44.Text = string.Format("{1}", tarih.ToShortDateString(), CHFDovizkodu) + "/TRY";

            string CHFDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/Unit").InnerXml;
            label45.Text = string.Format("{1}", tarih.ToShortDateString(), CHFDovizbirim);

            string CHFdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/Isim").InnerXml;
            label46.Text = string.Format("{1}", tarih.ToShortDateString(), CHFdovizcinsi);

            string CHFdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/ForexBuying").InnerXml;
            label47.Text = string.Format("{1}", tarih.ToShortDateString(), CHFdovizalis);

            string CHFdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/ForexSelling").InnerXml;
            label48.Text = string.Format("{1}", tarih.ToShortDateString(), CHFdovizsatis);

            string CHFdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/BanknoteBuying").InnerXml;
            label49.Text = string.Format("{1}", tarih.ToShortDateString(), CHFdovizefalis);

            string CHFdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/BanknoteSelling").InnerXml;
            label50.Text = string.Format("{1}", tarih.ToShortDateString(), CHFdovizefsatis);

            ///SEK İÇİN

            string SEKDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/@Kod").InnerXml;
            label51.Text = string.Format("{1}", tarih.ToShortDateString(), SEKDovizkodu) + "/TRY";

            string SEKDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/Unit").InnerXml;
            label52.Text = string.Format("{1}", tarih.ToShortDateString(), SEKDovizbirim);

            string SEKdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/Isim").InnerXml;
            label53.Text = string.Format("{1}", tarih.ToShortDateString(), SEKdovizcinsi);

            string SEKdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/ForexBuying").InnerXml;
            label54.Text = string.Format("{1}", tarih.ToShortDateString(), SEKdovizalis);

            string SEKdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/ForexSelling").InnerXml;
            label55.Text = string.Format("{1}", tarih.ToShortDateString(), SEKdovizsatis);

            string SEKdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/BanknoteBuying").InnerXml;
            label56.Text = string.Format("{1}", tarih.ToShortDateString(), SEKdovizefalis);

            string SEKdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/BanknoteSelling").InnerXml;
            label57.Text = string.Format("{1}", tarih.ToShortDateString(), SEKdovizefsatis);


            ///CAD İÇİN 

            string CADDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/@Kod").InnerXml;
            label58.Text = string.Format("{1}", tarih.ToShortDateString(), CADDovizkodu) + "/TRY";

            string CADDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/Unit").InnerXml;
            label59.Text = string.Format("{1}", tarih.ToShortDateString(), CADDovizbirim);

            string CADdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/Isim").InnerXml;
            label60.Text = string.Format("{1}", tarih.ToShortDateString(), CADdovizcinsi);

            string CADdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/ForexBuying").InnerXml;
            label61.Text = string.Format("{1}", tarih.ToShortDateString(), CADdovizalis);

            string CADdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/ForexSelling").InnerXml;
            label62.Text = string.Format("{1}", tarih.ToShortDateString(), CADdovizsatis);

            string CADdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/BanknoteBuying").InnerXml;
            label63.Text = string.Format("{1}", tarih.ToShortDateString(), CADdovizefalis);

            string CADdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/BanknoteSelling").InnerXml;
            label64.Text = string.Format("{1}", tarih.ToShortDateString(), CADdovizefsatis);


            ///KWD İÇİN
            ///

            string KWDDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/@Kod").InnerXml;
            label65.Text = string.Format("{1}", tarih.ToShortDateString(), KWDDovizkodu) + "/TRY";

            string KWDDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/Unit").InnerXml;
            label66.Text = string.Format("{1}", tarih.ToShortDateString(), KWDDovizbirim);

            string KWDdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/Isim").InnerXml;
            label67.Text = string.Format("{1}", tarih.ToShortDateString(), KWDdovizcinsi);

            string KWDdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/ForexBuying").InnerXml;
            label68.Text = string.Format("{1}", tarih.ToShortDateString(), KWDdovizalis);

            string KWDdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/ForexSelling").InnerXml;
            label69.Text = string.Format("{1}", tarih.ToShortDateString(), KWDdovizsatis);

            string KWDdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/BanknoteBuying").InnerXml;
            label70.Text = string.Format("{1}", tarih.ToShortDateString(), KWDdovizefalis);

            string KWDdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/BanknoteSelling").InnerXml;
            label71.Text = string.Format("{1}", tarih.ToShortDateString(), KWDdovizefsatis);

            ///NOK İÇİN 
            ///

            string NOKDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/@Kod").InnerXml;
            label72.Text = string.Format("{1}", tarih.ToShortDateString(), NOKDovizkodu) + "/TRY";

            string NOKDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/Unit").InnerXml;
            label73.Text = string.Format("{1}", tarih.ToShortDateString(), NOKDovizbirim);

            string NOKdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/Isim").InnerXml;
            label74.Text = string.Format("{1}", tarih.ToShortDateString(), NOKdovizcinsi);

            string NOKdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/ForexBuying").InnerXml;
            label75.Text = string.Format("{1}", tarih.ToShortDateString(), NOKdovizalis);

            string NOKdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/ForexSelling").InnerXml;
            label76.Text = string.Format("{1}", tarih.ToShortDateString(), NOKdovizsatis);

            string NOKdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/BanknoteBuying").InnerXml;
            label77.Text = string.Format("{1}", tarih.ToShortDateString(), NOKdovizefalis);

            string NOKdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/BanknoteSelling").InnerXml;
            label78.Text = string.Format("{1}", tarih.ToShortDateString(), NOKdovizefsatis);

            ///SAR İÇİN

            string SARDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/@Kod").InnerXml;
            label79.Text = string.Format("{1}", tarih.ToShortDateString(), SARDovizkodu) + "/TRY";

            string SARDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/Unit").InnerXml;
            label80.Text = string.Format("{1}", tarih.ToShortDateString(), SARDovizbirim);

            string SARdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/Isim").InnerXml;
            label81.Text = string.Format("{1}", tarih.ToShortDateString(), SARdovizcinsi);

            string SARdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/ForexBuying").InnerXml;
            label82.Text = string.Format("{1}", tarih.ToShortDateString(), SARdovizalis);

            string SARdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/ForexSelling").InnerXml;
            label83.Text = string.Format("{1}", tarih.ToShortDateString(), SARdovizsatis);

            string SARdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/BanknoteBuying").InnerXml;
            label84.Text = string.Format("{1}", tarih.ToShortDateString(), SARdovizefalis);

            string SARdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/BanknoteSelling").InnerXml;
            label85.Text = string.Format("{1}", tarih.ToShortDateString(), SARdovizefsatis);


            ///JPY İÇİN

            string JPYDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/@Kod").InnerXml;
            label86.Text = string.Format("{1}", tarih.ToShortDateString(), JPYDovizkodu) + "/TRY";

            string JPYDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/Unit").InnerXml;
            label87.Text = string.Format("{1}", tarih.ToShortDateString(), JPYDovizbirim);

            string JPYdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/Isim").InnerXml;
            label88.Text = string.Format("{1}", tarih.ToShortDateString(), JPYdovizcinsi);

            string JPYdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexBuying").InnerXml;
            label89.Text = string.Format("{1}", tarih.ToShortDateString(), JPYdovizalis);

            string JPYdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexSelling").InnerXml;
            label90.Text = string.Format("{1}", tarih.ToShortDateString(), JPYdovizsatis);

            string JPYdovizefalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/BanknoteBuying").InnerXml;
            label91.Text = string.Format("{1}", tarih.ToShortDateString(), JPYdovizefalis);

            string JPYdovizefsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/BanknoteSelling").InnerXml;
            label92.Text = string.Format("{1}", tarih.ToShortDateString(), JPYdovizefsatis);


            ///BGN İÇİN 

            string BGNDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='BGN']/@Kod").InnerXml;
            label93.Text = string.Format("{1}", tarih.ToShortDateString(), BGNDovizkodu) + "/TRY";

            string BGNDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='BGN']/Unit").InnerXml;
            label94.Text = string.Format("{1}", tarih.ToShortDateString(), BGNDovizbirim);

            string BGNdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='BGN']/Isim").InnerXml;
            label95.Text = string.Format("{1}", tarih.ToShortDateString(), BGNdovizcinsi);

            string BGNdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='BGN']/ForexBuying").InnerXml;
            label96.Text = string.Format("{1}", tarih.ToShortDateString(), BGNdovizalis);

            string BGNdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='BGN']/ForexSelling").InnerXml;
            label97.Text = string.Format("{1}", tarih.ToShortDateString(), BGNdovizsatis);

            ///RON İÇİN

            string RONDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RON']/@Kod").InnerXml;
            label100.Text = string.Format("{1}", tarih.ToShortDateString(), RONDovizkodu) + "/TRY";

            string RONDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RON']/Unit").InnerXml;
            label101.Text = string.Format("{1}", tarih.ToShortDateString(), RONDovizbirim);

            string RONdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RON']/Isim").InnerXml;
            label102.Text = string.Format("{1}", tarih.ToShortDateString(), RONdovizcinsi);

            string RONdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RON']/ForexBuying").InnerXml;
            label103.Text = string.Format("{1}", tarih.ToShortDateString(), RONdovizalis);

            string RONdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RON']/ForexSelling").InnerXml;
            label104.Text = string.Format("{1}", tarih.ToShortDateString(), RONdovizsatis);

            ///RUB İÇİN

            string RUBDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/@Kod").InnerXml;
            label107.Text = string.Format("{1}", tarih.ToShortDateString(), RUBDovizkodu) + "/TRY";

            string RUBDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/Unit").InnerXml;
            label108.Text = string.Format("{1}", tarih.ToShortDateString(), RUBDovizbirim);

            string RUBdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/Isim").InnerXml;
            label109.Text = string.Format("{1}", tarih.ToShortDateString(), RUBdovizcinsi);

            string RUBdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/ForexBuying").InnerXml;
            label110.Text = string.Format("{1}", tarih.ToShortDateString(), RUBdovizalis);

            string RUBdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/ForexSelling").InnerXml;
            label111.Text = string.Format("{1}", tarih.ToShortDateString(), RUBdovizsatis);

            //IRR İÇİN 


            string IRRDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='IRR']/@Kod").InnerXml;
            label114.Text = string.Format("{1}", tarih.ToShortDateString(), IRRDovizkodu) + "/TRY";

            string IRRDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='IRR']/Unit").InnerXml;
            label115.Text = string.Format("{1}", tarih.ToShortDateString(), IRRDovizbirim);

            string IRRdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='IRR']/Isim").InnerXml;
            label116.Text = string.Format("{1}", tarih.ToShortDateString(), IRRdovizcinsi);

            string IRRdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='IRR']/ForexBuying").InnerXml;
            label117.Text = string.Format("{1}", tarih.ToShortDateString(), IRRdovizalis);

            string IRRdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='IRR']/ForexSelling").InnerXml;
            label118.Text = string.Format("{1}", tarih.ToShortDateString(), IRRdovizsatis);

            ///CNY İÇİN
            ///

            string CNYDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CNY']/@Kod").InnerXml;
            label121.Text = string.Format("{1}", tarih.ToShortDateString(), CNYDovizkodu) + "/TRY";

            string CNYDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CNY']/Unit").InnerXml;
            label122.Text = string.Format("{1}", tarih.ToShortDateString(), CNYDovizbirim);

            string CNYdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CNY']/Isim").InnerXml;
            label123.Text = string.Format("{1}", tarih.ToShortDateString(), CNYdovizcinsi);

            string CNYdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CNY']/ForexBuying").InnerXml;
            label124.Text = string.Format("{1}", tarih.ToShortDateString(), CNYdovizalis);

            string CNYdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CNY']/ForexSelling").InnerXml;
            label125.Text = string.Format("{1}", tarih.ToShortDateString(), CNYdovizsatis);


            ///PKR İÇİN 

            string PKRDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='PKR']/@Kod").InnerXml;
            label98.Text = string.Format("{1}", tarih.ToShortDateString(), PKRDovizkodu) + "/TRY";

            string PKRDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='PKR']/Unit").InnerXml;
            label99.Text = string.Format("{1}", tarih.ToShortDateString(), PKRDovizbirim);

            string PKRdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='PKR']/Isim").InnerXml;
            label105.Text = string.Format("{1}", tarih.ToShortDateString(), PKRdovizcinsi);

            string PKRdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='PKR']/ForexBuying").InnerXml;
            label106.Text = string.Format("{1}", tarih.ToShortDateString(), PKRdovizalis);

            string PKRdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='PKR']/ForexSelling").InnerXml;
            label112.Text = string.Format("{1}", tarih.ToShortDateString(), PKRdovizsatis);

            ///QAR İÇİN
            ///
            string QARDovizkodu = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='QAR']/@Kod").InnerXml;
            label113.Text = string.Format("{1}", tarih.ToShortDateString(), QARDovizkodu) + "/TRY";

            string QARDovizbirim = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='QAR']/Unit").InnerXml;
            label119.Text = string.Format("{1}", tarih.ToShortDateString(), QARDovizbirim);

            string QARdovizcinsi = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='QAR']/Isim").InnerXml;
            label120.Text = string.Format("{1}", tarih.ToShortDateString(), QARdovizcinsi);

            string QARdovizalis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='QAR']/ForexBuying").InnerXml;
            label126.Text = string.Format("{1}", tarih.ToShortDateString(), QARdovizalis);

            string QARdovizsatis = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='QAR']/ForexSelling").InnerXml;
            label127.Text = string.Format("{1}", tarih.ToShortDateString(), QARdovizsatis);

































            //ÖRNEK

            ///string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            //label2.Text = string.Format("Tarih {0} EURO; {1}", tarih.ToShortDateString(), EURO);

            //string POUND = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
            // label3.Text = string.Format("Tarih {0} POUND; {1}", tarih.ToShortDateString(), POUND);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); //form2 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz

        }
    }
}
