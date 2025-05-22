using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Log_2._0
{
    class Languages
    {
        public static Dictionary<string, int> FormIndexes = new Dictionary<string, int>() {
            { "Base",       0 },
            { "Options",    1 },
            { "XML",        2 },
            { "ADD",        3 }
        };

        public static int SelectedLanguage = 0;
        public readonly static String[,,] AllLanguages = {
            {//English
                {"Activity Log 2.0", "Date", "Amount", "Activity type", "Comments", "Options", "Add",
                    "View Stats", "Calendar", "Remove", "Close", "Open in File Explorer", ""},                              //Base Form
                {"Options", "Add", "Rename", "Remove", "Up", "Down", "Done", "", "", "", "", "", ""},                       //Options Form
                {"Income", "Expenses", "Received Debt", "Payed out Debt", "", "", "", "", "", "", "", "", ""},              //XML File
                {"Add", "Information", "Add / Remove", "Amount", "Type", "Add", "Comments", "Date",
                    "Cash / Bank", "Cancel", "Done", "Cash", "Bank"}                                                        //ADD File
            },
            {//Latviešu
                {"Izdevumi 2.0", "Datums", "Apjoms", "Rādītāja Nosaukums", "Komentāri", "Opcijas",
                    "Jauns", "Līdzšinējie apr.", "Kalendārs", "Noņemt", "Aizvērt", "Atvērt Failu Pārlūkā", ""},             //Base Form
                {"Opcijas", "Jauns", "Pārdēvēt", "Noņemt", "Augšā", "Lejā", "Labi", "", "", "", "", "", ""},                //Options Form
                {"Ienākumi", "Izdevumi", "Ienākošie Aizdevumi", "Iznākošie Aizdevumi", "", "", "", "", "", "", "", "", ""}, //XML File
                {"Jauns", "Informācija", "Ienākumi / Izdevumi", "Apjoms", "R. Nosaukums", "Jauns", "Komentāri",
                    "Datums", "Skaidrā Nauda / Banka", "Atcelt", "Labi", "Skaidrā Nauda", "Banka"}                          //ADD File
            }
        }; 
    }
}
