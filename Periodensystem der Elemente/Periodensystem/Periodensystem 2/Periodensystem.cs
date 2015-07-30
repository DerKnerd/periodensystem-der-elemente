using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Periodensystem_2;
using System.Windows.Controls;
using System.Collections.Specialized;

namespace Periodensystem_2
{
    public class Element
    {
        public Element(string _name, string _ordnungszahl, string _massezahl,
            string _dichte, string _symbol, string _schmelztemperatur, string _siedetemperatur,
            bool _giftig, bool _radioaktiv, bool _ätzend, bool _entzündlich, bool _reizend)
        {
            name = _name;
            ordnungszahl = _ordnungszahl;
            massezahl = _massezahl;
            dichte = _dichte;
            symbol = _symbol;
            schmelztemperatur = _schmelztemperatur;
            siedetemperatur = _siedetemperatur;
            giftig = _giftig;
            radioaktiv = _radioaktiv;
            reizend = _reizend;
            ätzend = _ätzend;
            entzündlich = _entzündlich;
            reizend = _reizend;
        }
        #region private var
        private string name;
        private string ordnungszahl;
        private string massezahl;
        private string dichte;
        private string symbol;
        private string schmelztemperatur;
        private string siedetemperatur;

        private string siedepkteinheit;
        private string schmelzpkteinheit;
        private string massezahleinheit;
        private string dichteeinheit;

        private bool giftig;
        private bool radioaktiv;
        private bool ätzend;
        private bool entzündlich;
        private bool reizend;

        public const string tempein = "°C";
        public const string masseein = "u";
        public const string dichteein = "g/cm³";
        #endregion
        #region get{ ;} set{ ;}
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Ordnungszahl
        {
            get { return ordnungszahl; }
            set { ordnungszahl = value; }
        }
        public string Massezahl
        {
            get { return massezahl; }
            set { massezahl = value; }
        }
        public string Dichte
        {
            get { return dichte; }
            set { dichte = value; }
        }
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        public string Schmelztemperatur
        {
            get { return schmelztemperatur; }
            set { schmelztemperatur = value; }
        }
        public string Siedetemperatur
        {
            get { return siedetemperatur; }
            set { siedetemperatur = value; }
        }

        public string Siedepkteinheit
        {
            get { return siedepkteinheit; }
            set { siedepkteinheit = value; }
        }
        public string Schmelzpkteinheit
        {
            get { return schmelzpkteinheit; }
            set { schmelzpkteinheit = value; }
        }
        public string Massezahleinheit
        {
            get { return massezahleinheit; }
            set { massezahleinheit = value; }
        }
        public string Dichteeinheit
        {
            get { return dichteeinheit; }
            set { dichteeinheit = value; }
        }

        public bool Giftig
        {
            get { return giftig; }
            set { giftig = value; }
        }
        public bool Radioaktiv
        {
            get { return radioaktiv; }
            set { radioaktiv = value; }
        }
        public bool Ätzend
        {
            get { return radioaktiv; }
            set { radioaktiv = value; }
        }
        public bool Entzündlich
        {
            get { return entzündlich; }
            set { entzündlich = value; }
        }
        public bool Reizend
        {
            get { return reizend; }
            set { reizend = value; }
        }
        #endregion
        public override string ToString()
        {
            return (Name + "(" + Symbol + ")");
        }
    }
    public class ElementeCollection : ObservableCollection<Element> 
    {
        public void AddRange(Element[] e)
        {
            foreach (Element item in e)
            {
                this.Add(item);
            }
        }
        public void Sort()
        {
            Element[] elemente = this.ToArray<Element>();
            Array.Sort(elemente);
            this.Clear();
            foreach (Element item in elemente)
            {
                this.Add(item);
            }
        }

    }
    public class Elemente
    {
        public static readonly Element[] elemente = new Element[98] 
        { 
            H,Li,Na,K,Rb,Cs,Fr,
            Be,Mg,Ca,Sr,Ba,Ra,
            B,Al,Ga,In,Tl,
            C,Si,Ge,Sn,Pb,
            N,P,As,Sb,Bi,
            O,S,Se,Te,Po,
            F,Cl,Br,I,At,
            He,Ne,Ar,Kr,Xe,Rn,
            Cu,Ag,Au,
            Zn,Cd,Hg,
            Sc,Y,La,Ac,
            Ti,Zr,Hf,
            V,Nb,Ta,
            Cr,Mo,W,
            Mn,Tc,Re,
            Fe,Ru,Os,Co,Rh,Ir,Ni,Pd,Pt,
            Ce,Pr,Nd,Pm,Sm,Eu,Gd,Tb,Dy,Ho,Er,Tm,Yb,Lu,
            Th,Pa,U,Np,Pu,Am,Cm,Bk,Cf
        };
        //Erste Hauptgruppe
        public readonly static Element H = new Element("Wasserstoff", "1", "1", "0,09", "H", "-259", "-253", false, false, false, true, false);
        public readonly static Element Li = new Element("Lithium", "3", "7", "0,53", "Li", "181", "1342", false, false, true, true, false);
        public readonly static Element Na = new Element("Natrium", "11", "23", "0,97", "Na", "98", "883", false, false, true, true, false);
        public readonly static Element K = new Element("Kalium", "19", "39", "0,86", "K", "63", "759", false, false, true, true, false);
        public readonly static Element Rb = new Element("Rubidium", "37", "85", "1,53", "Rb", "39", "686", false, false, true, true, false);
        public readonly static Element Cs = new Element("Caesium", "55", "133", "1,9", "Cs", "28", "671", false, false, true, true, false);
        public readonly static Element Fr = new Element("Francium", "87", "223", "-", "Fr", "27", "677", false, true, false, false, false);
        public readonly static Element[] ersteHauptgruppe = new Element[7]
        {
            H,Li,Na,K,Rb,Cs,Fr
        };
        public readonly static ListBoxItem[] erstehauptgruppe = new ListBoxItem[7]
        {
            new ListBoxItem(){ Content=H.Name, Name="H"},
            new ListBoxItem(){ Content=Li.Name, Name="Li"},
            new ListBoxItem(){ Content=Na.Name, Name="Na"},
            new ListBoxItem(){ Content=K.Name, Name="K"},
            new ListBoxItem(){ Content=Rb.Name, Name="Rb"},
            new ListBoxItem(){ Content=Cs.Name, Name="Cs"},
            new ListBoxItem(){ Content=Fr.Name, Name="Fr"},
        };
        //Zweite Hauptgruppe
        public readonly static Element Be = new Element("Beryllium", "4", "9", "1,85", "Be", "1287", "2469", true, false, false, false, false);
        public readonly static Element Mg = new Element("Magnesium", "12", "24", "1,74", "Mg", "650", "1090", false, false, false, true, false);
        public readonly static Element Ca = new Element("Calcium", "20", "40", "1,55", "Ca", "842", "1484", false, false, false, true, false);
        public readonly static Element Sr = new Element("Strontium", "38", "85", "2,63", "Sr", "777", "1382", false, false, false, true, false);
        public readonly static Element Ba = new Element("Barium", "56", "137", "3,62", "Ba", "727", "1870", false, false, false, true, false);
        public readonly static Element Ra = new Element("Radium", "88", "226", "5,5", "Ra", "700", "1737", false, true, false, false, false);
        public readonly static Element[] zweiteHauptgruppe = new Element[6]
        {
            Be,Mg,Ca,Sr,Ba,Ra
        };
        public readonly static ListBoxItem[] zweitehauptgruppe = new ListBoxItem[6]
        {
            new ListBoxItem(){ Content=Be.Name, Name="Be"},
            new ListBoxItem(){ Content=Mg.Name, Name="Mg"},
            new ListBoxItem(){ Content=Ca.Name, Name="Ca"},
            new ListBoxItem(){ Content=Sr.Name, Name="Sr"},
            new ListBoxItem(){ Content=Ba.Name, Name="Ba"},
            new ListBoxItem(){ Content=Ra.Name, Name="Ra"},
        };

        //Dritte Nebengruppe
        public readonly static Element Sc = new Element("Scandium", "21", "45", "2,99", "Sc", "1541", "2830", false, false, false, true, false);
        public readonly static Element Y = new Element("Yttrium", "39", "89", "4,47", "Y", "1526", "3336", false, false, false, true, false);
        public readonly static Element La = new Element("Lanthan", "57", "139", "6,15", "La", "920", "3470", false, false, false, true, false);
        public readonly static Element Ac = new Element("Actinium", "89", "227", "10,07", "Ac", "1050", "3300", false, true, false, false, false);
        public readonly static Element[] dritteNebengruppe = new Element[4]
        {
            Sc,Y,La,Ac
        };
        public readonly static ListBoxItem[] drittenebengruppe = new ListBoxItem[4]
        {
            new ListBoxItem(){ Content=Sc.Name, Name="Sc"},
            new ListBoxItem(){ Content=Y.Name, Name="Y"},
            new ListBoxItem(){ Content=La.Name, Name="La"},
            new ListBoxItem(){ Content=Ac.Name, Name="Ac"},
        };

        //Lanthanoide
        public readonly static Element Ce = new Element("Cer", "58", "140", "6,69", "Ce", "795", "3360", false, false, false, true, false);
        public readonly static Element Pr = new Element("Praseodym", "59", "141", "6,64", "Pr", "935", "3290", false, false, false, true, false);
        public readonly static Element Nd = new Element("Neodym", "60", "144", "6,8", "Nd", "1024", "3100", false, false, false, true, true);
        public readonly static Element Pm = new Element("Promethium", "61", "147", "7,22", "Pm", "1100", "3000", false, true, false, false, false);
        public readonly static Element Sm = new Element("Samarium", "62", "150", "7,35", "Sm", "1072", "1803", false, false, false, false, false);
        public readonly static Element Eu = new Element("Europium", "63", "152", "5,24", "Eu", "826", "1527", false, false, false, true, false);
        public readonly static Element Gd = new Element("Gadolinium", "64", "157", "7,9", "Gd", "1312", "3250", false, false, false, true, false);
        public readonly static Element Tb = new Element("Terbium", "65", "159", "8,22", "Tb", "1356", "3230", false, false, false, false, false);
        public readonly static Element Dy = new Element("Dysprosium", "66", "163", "8,55", "Dy", "1407", "2567", false, false, false, true, false);
        public readonly static Element Ho = new Element("Holmium", "67", "165", "8,8", "Ho", "1461", "2720", false, false, false, false, false);
        public readonly static Element Er = new Element("Erbium", "68", "167", "9,07", "Er", "1529", "2868", false, false, false, true, false);
        public readonly static Element Tm = new Element("Thulium", "69", "169", "9,32", "Tm", "1545", "1950", false, false, false, true, true);
        public readonly static Element Yb = new Element("Ytterbium", "70", "173", "6,57", "Yb", "824", "1196", false, false, false, true, true);
        public readonly static Element Lu = new Element("Luthetium", "71", "175", "9,84", "Lu", "1652", "3402", false, false, false, true, false);
        public readonly static Element[] Lanthanoide = new Element[14]
        {
            Ce,Pr,Nd,Pm,Sm,Eu,Gd,Tb,Dy,Ho,Er,Tm,Yb,Lu
        };
        public readonly static ListBoxItem[] lanthanoide = new ListBoxItem[14]
        {
            new ListBoxItem(){ Content=Ce.Name, Name="Ce"},
            new ListBoxItem(){ Content=Pr.Name, Name="Pr"},
            new ListBoxItem(){ Content=Nd.Name, Name="Nd"},
            new ListBoxItem(){ Content=Pm.Name, Name="Pm"},
            new ListBoxItem(){ Content=Sm.Name, Name="Sm"},
            new ListBoxItem(){ Content=Eu.Name, Name="Eu"},
            new ListBoxItem(){ Content=Gd.Name, Name="Gd"},
            new ListBoxItem(){ Content=Tb.Name, Name="Tb"},
            new ListBoxItem(){ Content=Dy.Name, Name="Dy"},
            new ListBoxItem(){ Content=Ho.Name, Name="Ho"},
            new ListBoxItem(){ Content=Er.Name, Name="Er"},
            new ListBoxItem(){ Content=Tm.Name, Name="Tm"},
            new ListBoxItem(){ Content=Yb.Name, Name="Yb"},
            new ListBoxItem(){ Content=Lu.Name, Name="Lu"},
        };
        
        //Actinoide
        public readonly static Element Th = new Element("Thorium", "90", "232", "11,72", "Th", "1755", "4788", false, true, false, false, false);
        public readonly static Element Pa = new Element("Protactinium", "91", "231", "15,37", "Pa", "1568", "4000", false, true, false, false, false);
        public readonly static Element U = new Element("Uran", "92", "238", "19,16", "U", "1133", "3930", true, true, false, false, false);
        public readonly static Element Np = new Element("Neptunium", "93", "237", "20,45", "Np", "639", "3902", false, true, false, false, false);
        public readonly static Element Pu = new Element("Plutonium", "94", "244", "19,82", "Pu", "639", "3230", false, true, false, false, false);
        public readonly static Element Am = new Element("Americum", "95", "243", "13,67", "Am", "1176", "2607", false, true, false, false, false);
        public readonly static Element Cm = new Element("Curium", "96", "247", "13,51", "Cm", "1340", "3110", false, true, false, false, false);
        public readonly static Element Bk = new Element("Berkelium", "97", "247", "14,78", "Bk", "986", "2623", false, true, false, false, false);
        public readonly static Element Cf = new Element("Californium", "98", "251", "15,1", "Cf", "900", "-", false, true, false, false, false);
        public readonly static Element[] Actinoide = new Element[9]
        {
            Th,Pa,U,Np,Pu,Am,Cm,Bk,Cf,
        };
        public readonly static ListBoxItem[] actinoide = new ListBoxItem[9]
        {
            new ListBoxItem(){ Content=Th.Name, Name="Th"},
            new ListBoxItem(){ Content=Pa.Name, Name="Pa"},
            new ListBoxItem(){ Content=U.Name, Name="U"},
            new ListBoxItem(){ Content=Np.Name, Name="Np"},
            new ListBoxItem(){ Content=Pu.Name, Name="Pu"},
            new ListBoxItem(){ Content=Am.Name, Name="Am"},
            new ListBoxItem(){ Content=Cm.Name, Name="Cm"},
            new ListBoxItem(){ Content=Bk.Name, Name="Bk"},
            new ListBoxItem(){ Content=Cf.Name, Name="Cf"},
        };

        //Vierte Nebengruppe
        public readonly static Element Ti = new Element("Titan", "22", "48", "4,5", "Ti", "1668", "3287", false, false, false, true, true);
        public readonly static Element Zr = new Element("Zirconium", "40", "91", "6,51", "Zr", "1857", "4409", false, false, false, true, false);
        public readonly static Element Hf = new Element("Hafnium", "72", "179", "13,28", "Hf", "2233", "4603", false, false, false, true, false);
        public readonly static Element[] vierteNebengruppe = new Element[3]
        {
            Ti,Zr,Hf,
        };
        public readonly static ListBoxItem[] viertenebengruppe = new ListBoxItem[3]
        {
            new ListBoxItem(){ Content=Ti.Name, Name="Ti"},
            new ListBoxItem(){ Content=Zr.Name, Name="Zr"},
            new ListBoxItem(){ Content=Hf.Name, Name="Hf"},
        };
        //Fünfte Nebengruppe
        public readonly static Element V = new Element("Vanadium", "23", "51", "6,11", "V", "1910", "3407", false, false, false, true, true);
        public readonly static Element Nb = new Element("Niob", "41", "93", "8,57", "Nb", "2477", "4744", false, false, false, true, false);
        public readonly static Element Ta = new Element("Tantal", "73", "181", "16,65", "Ta", "3017", "5458", false, false, false, true, false);
        public readonly static Element[] fünfteNebengruppe = new Element[3]
        {
            V,Nb,Ta
        };
        public readonly static ListBoxItem[] fünftenebengruppe = new ListBoxItem[3]
        {
            new ListBoxItem(){ Content=V.Name, Name="V"},
            new ListBoxItem(){ Content=Nb.Name, Name="Nb"},
            new ListBoxItem(){ Content=Ta.Name, Name="Ta"},
        };
        //Sechste Nebengruppe
        public readonly static Element Cr = new Element("Chrom", "24", "48", "7,14", "Cr", "1907", "2671", false, false, false, true, false);
        public readonly static Element Mo = new Element("Molybdän", "42", "96", "10,28", "Mo", "2623", "4639", false, false, false, false, false);
        public readonly static Element W = new Element("Wolfram", "74", "184", "19,3", "W", "3422", "5555", false, false, false, false, false);
        public readonly static Element[] sechsteNebengruppe = new Element[3]
        {
            Cr,Mo,W
        };
        public readonly static ListBoxItem[] sechstenebengruppe = new ListBoxItem[3]
        {
            new ListBoxItem(){ Content=Cr.Name, Name="Cr"},
            new ListBoxItem(){ Content=Mo.Name, Name="Mo"},
            new ListBoxItem(){ Content=W.Name, Name="W"},
        };
        //Siebte Nebengruppe
        public readonly static Element Mn = new Element("Mangan", "25", "55", "7,43", "Mn", "1246", "2061", false, false, false, true, false);
        public readonly static Element Tc = new Element("Technetium", "43", "99", "11,5", "Tc", "2157", "4265", false, true, false, false, false);
        public readonly static Element Re = new Element("Rhenium", "75", "186", "21", "Re", "3186", "5596", false, false, false, true, false);
        public readonly static Element[] siebteNebengruppe = new Element[3]
        {
            Mn,Tc,Re
        };
        public readonly static ListBoxItem[] siebtenebengruppe = new ListBoxItem[3]
        {
            new ListBoxItem(){ Content=Mn.Name, Name="Mn"},
            new ListBoxItem(){ Content=Tc.Name, Name="Tc"},
            new ListBoxItem(){ Content=Re.Name, Name="Re"},
        };
        //Achte Nebengruppe
        public readonly static Element Fe = new Element("Eisen", "26", "56", "7,87", "Fe", "1538", "2861", false, false, false, true, false);
        public readonly static Element Ru = new Element("Ruthenium", "44", "101", "12,37", "Ru", "2334", "4150", false, false, false, true, false);
        public readonly static Element Os = new Element("Osmium", "76", "190", "22,59", "Os", "3130", "5000", false, false, false, true, true);

        public readonly static Element Co = new Element("Cobalt", "27", "59", "8,9", "Co", "1495", "2927", false, false, false, false, false);
        public readonly static Element Rh = new Element("Rhodium", "45", "103", "12,38", "Rh", "1964", "3695", false, false, false, true, false);
        public readonly static Element Ir = new Element("Iridium", "77", "192", "22,56", "Ir", "2466", "4428", false, false, false, true, false);

        public readonly static Element Ni = new Element("Nickel", "28", "59", "8,91", "Ni", "1455", "2913", true, false, false, false, false);
        public readonly static Element Pd = new Element("Palladium", "46", "106", "11,99", "Pd", "1555", "2963", false, false, false, true, true);
        public readonly static Element Pt = new Element("Platin", "78", "195", "21,45", "Pt", "1768", "3825", false, false, false, true, false);
        public readonly static Element[] achteNebengruppe = new Element[9]
        {
            Fe,Ru,Os,Co,Rh,Ir,Ni,Pd,Pt
        };
        public readonly static ListBoxItem[] achtenebengruppe = new ListBoxItem[9]
        {
            new ListBoxItem(){ Content=Fe.Name, Name="Fe"},
            new ListBoxItem(){ Content=Ru.Name, Name="Ru"},
            new ListBoxItem(){ Content=Os.Name, Name="Os"},
            new ListBoxItem(){ Content=Co.Name, Name="Co"},
            new ListBoxItem(){ Content=Rh.Name, Name="Rh"},
            new ListBoxItem(){ Content=Ir.Name, Name="Ir"},
            new ListBoxItem(){ Content=Ni.Name, Name="Ni"},
            new ListBoxItem(){ Content=Pd.Name, Name="Pd"},
            new ListBoxItem(){ Content=Pt.Name, Name="Pt"},
        };
        //Erste Nebengruppe
        public readonly static Element Cu = new Element("Kupfer", "29", "64", "8,92", "Cu", "1085", "2927", false, false, false, false, false);
        public readonly static Element Ag = new Element("Silber", "47", "108", "10,49", "Ag", "962", "2162", false, false, false, false, false);
        public readonly static Element Au = new Element("Gold", "79", "197", "19,32", "Au", "1064", "2856", false, false, false, false, false);
        public readonly static Element[] ersteNebengruppe = new Element[3]
        {
            Cu,Ag,Au
        };
        public readonly static ListBoxItem[] erstenebengruppe = new ListBoxItem[3]
        {
            new ListBoxItem(){ Content=Cu.Name, Name="Cu"},
            new ListBoxItem(){ Content=Ag.Name, Name="Ag"},
            new ListBoxItem(){ Content=Au.Name, Name="Au"},
        };
        //Zweite Nebengruppe
        public readonly static Element Zn = new Element("Zinn", "30", "65", "7,14", "Zn", "420", "907", false, false, false, true, false);
        public readonly static Element Cd = new Element("Cadmium", "48", "112", "8,65", "Cd", "321", "767", true, false, false, true, false);
        public readonly static Element Hg = new Element("Quecksilber", "80", "201", "13,55", "Hg", "-39", "357", true, false, false, false, false);
        public readonly static Element[] zweiteNebengruppe = new Element[3]
        {
            Zn,Cd,Hg
        };
        public readonly static ListBoxItem[] zweitenebengruppe = new ListBoxItem[3]
        {
            new ListBoxItem(){ Content=Zn.Name, Name="Zn"},
            new ListBoxItem(){ Content=Cd.Name, Name="Cd"},
            new ListBoxItem(){ Content=Hg.Name, Name="Hg"},
        };
        
        //Dritte Hauptgruppe
        public readonly static Element B = new Element("Bor", "5", "11", "2,46", "B", "2076", "3927", false, false, false, false, false);
        public readonly static Element Al = new Element("Aluminium", "13", "27", "2,7", "Al", "660", "2467", false, false, false, true, false);
        public readonly static Element Ga = new Element("Gallium", "31", "70", "5,9", "Ga", "30", "2204", false, false, true, false, false);
        public readonly static Element In = new Element("Indium", "49", "115", "7,31", "In", "157", "2072", false, false, false, true, false);
        public readonly static Element Tl = new Element("Thallium", "81", "204", "11,85", "Tl", "304", "1473", true, false, false, false, false);
        public readonly static Element[] dritteHauptgruppe = new Element[5]
        {
            B,Al,Ga,In,Tl
        };
        public readonly static ListBoxItem[] drittehauptgruppe = new ListBoxItem[5]
        {
            new ListBoxItem(){ Content=B.Name, Name="B"},
            new ListBoxItem(){ Content=Al.Name, Name="Al"},
            new ListBoxItem(){ Content=Ga.Name, Name="Ga"},
            new ListBoxItem(){ Content=In.Name, Name="In"},
            new ListBoxItem(){ Content=Tl.Name, Name="Tl"},
        };
        //Vierte Hauptgruppe
        public readonly static Element C = new Element("Kohlenstoff", "6", "12", "2,89", "C", "3550", "3900", false, false, false, false, false);
        public readonly static Element Si = new Element("Silicium", "14", "28", "2,33", "Si", "1410", "2355", false, false, false, true, true);
        public readonly static Element Ge = new Element("Germanium", "32", "73", "5,32", "Ge", "938", "2820", false, false, false, true, false);
        public readonly static Element Sn = new Element("Zinn", "50", "119", "7,27", "Sn", "232", "2602", false, false, false, false, false);
        public readonly static Element Pb = new Element("Blei", "82", "207", "11,34", "Pb", "327", "1749", true, false, false, false, false);
        public readonly static Element[] vierteHauptgruppe = new Element[5]
        {
            C,Si,Ge,Sn,Pb
        };
        public readonly static ListBoxItem[] viertehauptgruppe = new ListBoxItem[5]
        {
            new ListBoxItem(){ Content=C.Name, Name="C"},
            new ListBoxItem(){ Content=Si.Name, Name="Si"},
            new ListBoxItem(){ Content=Ge.Name, Name="Ge"},
            new ListBoxItem(){ Content=Sn.Name, Name="Sn"},
            new ListBoxItem(){ Content=Pb.Name, Name="Pb"},
        };
        //Fünfte Hauptgruppe
        public readonly static Element N = new Element("Stickstoff", "7", "14", "1,25", "N", "-210", "-196", false, false, false, false, false);
        public readonly static Element P = new Element("Phosphor", "15", "31", "1,83", "P", "44", "277", true, false, true, true, false);
        public readonly static Element As = new Element("Arsen", "33", "75", "5,72", "As", "817", "613", true, false, false, false, false);
        public readonly static Element Sb = new Element("Antimon", "51", "122", "6,7", "Sb", "631", "1587", false, false, false, false, true);
        public readonly static Element Bi = new Element("Bismut", "83", "208", "9,78", "Bi", "271", "1564", false, false, false, true, false);
        public readonly static Element[] fünfteHauptgruppe = new Element[5]
        {
            N,P,As,Sb,Bi
        };
        public readonly static ListBoxItem[] fünftehauptgruppe = new ListBoxItem[5]
        {
            new ListBoxItem(){ Content=N.Name, Name="N"},
            new ListBoxItem(){ Content=P.Name, Name="P"},
            new ListBoxItem(){ Content=As.Name, Name="As"},
            new ListBoxItem(){ Content=Sb.Name, Name="Sb"},
            new ListBoxItem(){ Content=Bi.Name, Name="Bi"},
        };
        //Sechste Hauptgruppe
        public readonly static Element O = new Element("Sauerstoff", "8", "16", "1,43", "O", "-219", "-183", false, false, false, false, false);
        public readonly static Element S = new Element("Schwefel", "16", "32", "2,07", "S", "115", "445", false, false, false, false, true);
        public readonly static Element Se = new Element("Selen", "34", "79", "4,82", "Se", "221", "685", true, false, false, false, false);
        public readonly static Element Te = new Element("Tellur", "52", "128", "6,24", "Te", "450", "988", false, false, false, false, true);
        public readonly static Element Po = new Element("Polonium", "84", "210", "9,2", "Po", "254", "962", false, true, false, false, false);
        public readonly static Element[] sechsteHauptgruppe = new Element[5]
        {
            O,S,Se,Te,Po
        };
        public readonly static ListBoxItem[] sechstehauptgruppe = new ListBoxItem[5]
        {
            new ListBoxItem(){ Content=O.Name, Name="O"},
            new ListBoxItem(){ Content=S.Name, Name="S"},
            new ListBoxItem(){ Content=Se.Name, Name="Se"},
            new ListBoxItem(){ Content=Te.Name, Name="Te"},
            new ListBoxItem(){ Content=Po.Name, Name="Po"},
        };
        //Siebte Hauptgruppe
        public readonly static Element F = new Element("Flour", "9", "19", "1,7", "F", "-220", "-188", true, false, true, false, false);
        public readonly static Element Cl = new Element("Chlor", "17", "35", "3,22", "Cl", "-102", "-34", false, false, false, false, true);
        public readonly static Element Br = new Element("Brom", "35", "59", "3,12", "Br", "-7", "59", false, false, false, false, false);
        public readonly static Element I = new Element("Iod", "53", "127", "4,94", "I", "114", "184", false, false, false, false, false);
        public readonly static Element At = new Element("Astat", "85", "210", "-", "At", "302", "335", false, true, false, false, false);
        public readonly static Element[] siebteHauptgruppe = new Element[5]
        {
            F,Cl,Br,I,At
        };
        public readonly static ListBoxItem[] siebtehauptgruppe = new ListBoxItem[5]
        {
            new ListBoxItem(){ Content=F.Name, Name="F"},
            new ListBoxItem(){ Content=Cl.Name, Name="Cl"},
            new ListBoxItem(){ Content=Br.Name, Name="Br"},
            new ListBoxItem(){ Content=I.Name, Name="I"},
            new ListBoxItem(){ Content=At.Name, Name="At"},
        };
        //Achte Hauptgruppe
        public readonly static Element He = new Element("Helium", "2", "4", "0,18", "He", "-272", "-269", false, false, false, false, false);
        public readonly static Element Ne = new Element("Neon", "10", "20", "0,9", "Ne", "-249", "-246", false, false, false, false, false);
        public readonly static Element Ar = new Element("Argon", "18", "40", "1,78", "Ar", "-189", "-186", false, false, false, false, false);
        public readonly static Element Kr = new Element("Krypton", "36", "84", "3,75", "Kr", "-157", "-153", false, false, false, false, false);
        public readonly static Element Xe = new Element("Xenon", "54", "131", "5,9", "Xe", "-112", "-108", false, false, false, false, false);
        public readonly static Element Rn = new Element("Radon", "86", "222", "9,73", "Rn", "-71", "-62", false, true, false, false, false);
        public readonly static Element[] achteHauptgruppe = new Element[6]
        {
            He,Ne,Ar,Kr,Xe,Rn
        };
        public readonly static ListBoxItem[] achtehauptgruppe = new ListBoxItem[6]
        {
            new ListBoxItem(){ Content=He.Name, Name="He"},
            new ListBoxItem(){ Content=Ne.Name, Name="Ne"},
            new ListBoxItem(){ Content=Ar.Name, Name="Ar"},
            new ListBoxItem(){ Content=Kr.Name, Name="Kr"},
            new ListBoxItem(){ Content=Xe.Name, Name="Xe"},
            new ListBoxItem(){ Content=Rn.Name, Name="Rn"},
        };
    }
}
