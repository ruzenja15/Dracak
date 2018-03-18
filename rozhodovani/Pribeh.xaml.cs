using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rozhodovani
{
    /// <summary>
    /// Interakční logika pro Pribeh.xaml
    /// </summary>
    public partial class Pribeh : Page
    {
        public Player player;
        public Dialog currentdialog;
        public int index = 0;
 
        public Pribeh(Dialog dialog = null, int level = 1)
        {


            InitializeComponent();
            player = new Player(level);
            

            Dialog dialog1 = new Dialog( "Vítej ve hře", "Chceš přiblížit o co v příběhu jde ? ");

            Dialog dialog2 = new Dialog( "Člověk, opovrhovaná rasa. Téměř všichni lidé byli vyvražděni nebo zneškodněni.", "Celému světu panuje Temný lord, který rozhoduje o osudu lidí. Nikdo ho však neviděl bez jeho brnění a masky.", "Každý den se zbytky lidí převáží na popraviště, kde se jich zbavuje.", "A zde začíná příběh Frankieho, který byl 3 roky mučen a  byly mu dávány drogy, aby zapomněl na svoji minulost", "jsi ready?");

            Dialog dialog3 = new Dialog( "Vzbudil ses a zjistil si, že se nacházíš ve voze na popravu.", "Frankie:\n'Situace vypadá bezradně, vypadá to, že všichni umřeme.'", "Hned jak jsi to dořekl, uslyšel jsi podezřelou ránu", "Celý vůz se zatšásl a spadl na bok. Díky tvrdému pádu se rozbily dveře a všichni lidé mohli utéct", "Frankie: \nCo se to stalo ? Tohle nemůže být náhoda.", "Taky že nebyla, v momentě co jsi opustil vůz, přiběhli k tobě ozbrojení lidé a podali ti meč", "Co uděláš ?");

            //První Rozhodnutí

            Dialog dialog4 = new Dialog(true, player, new Enemy(player.level, "Fanatic", Enemy.Type.BASIC));

            Dialog dialog13 = new Dialog("Všichni vojáci, co měli převoz na starost jsou poraženi", "A tobě se naskytla otázka, 'Komu jsem to vlastně pomohl?", "Bylo ti řečeno, že jsou z odboje, který zachraňuje lidi, před smrtí a za tvojí pomoc ti jsou vděční.");



            Dialog dialog5 = new Dialog("Utekl jsi do lesa a boj pozoruješ z dálky.", "Frankie:\nMůžu těm lidem vůbec věřit? Sice nás všechny dostali z vozu na popravu, ale proč by to dělali?", "Frankie je skeptický, přecejenom 3 roky byl mučen právě lidma od Temného lorda.", "Temný lord si lidi rád ochočuje a pokud jim nejde vymýt mozek, jdou na popravu.", "Celá jeho armáda je složená právě lidma, kteří zapomněli na všechno důležité a jsou schopni bez váhání zabít i vlastního člena rodiny. Těmto lidem se říká 'Spadlí'.", "Každý Spadlý má na bedrech cejchu, Díky které se dá bezpečně poznat.", "Jedná se tedy o Spadlé ? A pokud ano, jsou nebezpeční ?", "Boj skončil, všichni vojáci byli poraženi." );
            //Druhý Rozhodnutí / Po čekání v lese + Nezdají se mi
            Dialog dialog6 = new Dialog(true, player, new Enemy(player.level, "Bandit", Enemy.Type.BASIC));





            Dialog dialog7 = new Dialog("Po boji jsi zkontroloval jejich bedra a zjistli jsi, že všichni cejch mají", "Když jsi kontroloval posledního, aby ses ujistil, že všichni byli Spadlí, pohnul se a promluvil Sípavým hlasem:'Za lidstvo'", "Ztuhl jsi, 'jak může Spadlý něco takového říct ? ' pomyslel sis", "Najednou slyšíš kopyta asi 15 koní jak se k tobě blíží", "Popadl jsi meč a čekáš na příjezd. V tu chvíli tě silně raněný můž chytí za nohu a zařvě 'Utíkej Spadlí se blíží'.", "Co uděláš ?");              
            //Třetí Rozhodnutí / Po kontrole Spadlých
         /*KONEC BAD SEBEVRAŽDA*/Dialog dialog8 = new Dialog("začal jsi utíkat co ti síly stačily, asi po půl hodině vysilujícího běhu ses rozodl zastavit, aby sis dal myšlenky dohromady.", "Došlo ti, že ty co jsi zabil nebyli Spadlí, ale lidé co se vydávali za Spadlé, aby se mohli lépe pohybovat v této zemi", "Udělal jsem strašnou věc, zabil jsem všechny členy odboje co se mě pokusili zachránit", "Nevydržel jsi tíhu viny a rozhodl ses ukončit život.", "KONEC" );


            Dialog dialog9 = new Dialog("Muž nešel umlčet po dobrém, tak jsi ho zabil.", "Muž měl pravdu, opravdu se jednalo o Spadlé, bohužel nemáš na výběr a musíš jít s nimi.", "Frankie\n'Kam mě vůbec vezete ?'\nSpadlý neodpověděl, asi to má zakázané od temného lorda.", "Po dlouhých hodinách mlčení jsi dorazil na Temný hrad, kde na tebe čeká Temný lord.", "Temný lord:\n'Výborná Práce, Frankie, podařilo se ti eliminovat celý odboj.'", "Frankie:\n'Moment, co myslíš tím eliminovat odboj ?'", "Temný lord:\n'Ti lidi, co jsi zabil, byli z odboje, pomáhali ostatním lidem útéct před smrtí.'", "Temný lord:\n'Já a moje armáda jsme se je snažili zabít již léta a pořád nám prokluzovali mezi prsty.'", "Temný lord:\n'Já věděl, že se mi vyplatíš, Frankie.'", "Frankie:\n'Jak znáš mé jméno ? a co myslíš tím vyplatil ?!'", "Temný lord si sundal helmu a to co jsi spatřil bylo až neuvěřitelné .", "Frankie:\n'Ty jsi celou tu donu člověk ?!'", "Temný lord:\n'Hádám, že si to asi nepamatuješ, můj milý bratříčku.'", "Zcela jsi ztuhnul, vůbec nechápeš o co jde. Co myslí tím Bratříčku a co přesně by sis měl pamatovat?", "Temný lord:\n'Když jsme byli ještě malí kluci, žili jsme v hlavním městě a naši rodiče pracovali jako sluhové pro krále.'", "Temný lord:\n'Spokojeně jsme si žili až jednoho dne přišla událost, která nám dvoum změnila životy", "Temný lord:\n'Král měl v oblibě malé kluky, asi ti nemusím říkat co s nimi prováděl'", "Temný lord:\n'No a my dva jsme měli být jeho další společnost, rodiče nás bránili do posledního dechu a podařilo se jim nás zachránit, ale bohužel, král je nechal popravit.'", "Temný lord:\n'Po tom všem co jsme viděli a zažili jsem se rozhodli eliminovat krále tím, že prozradíme jeho tajemství, ale jak jsme se s hruzou dozvěděli, každý po jeho boku o tom věděl'", "Temný lord:\n'Každý věděl, že znásilňuje a zabíjí, ale nic s tím nikdo neudělal.'", "Temný lord:\n'Náš pohled na lidstvo se změnil, nesnášeli jsme je a proto jsme je všechny vyvraždili.'", "Temný lord:\n'Získali jsme moc a společně jsme likvidovali všechy lidi'", "Frankie:\n'NE ? TO NENÍ PRAVDA. TY MI LŽEŠ, proč jsem teda jel na popravu ?'", "Temný lord:\n'nechal sis dobrovolně vymýt mozek aby jsi infiltroval odboj a zabil je, bylo to trochu riskantní, mohl jsi na svůj úkol zapomenout a přidat se k nim.'", "Temný lord:\n'Ale zvládl jsi to na jedničku'", "Frankie:\n'Vůbec nevím co si mám myslet a co mám teď dělat'", "Temný lord:\n'To se budeš muset rozhodnout sám bratříčku'", "Co uděláš?");
            Dialog dialog10 = new Dialog(true, player, new Enemy(player.level, "Bandit", Enemy.Type.BASIC));
          /*KONEC GOOD PANOVNÍK*/  Dialog dialog11 = new Dialog("Temný lord byl zabit tvojí rukou, při pohledu na jeho mrtvolu sis na všechno vzpomněl, téměř vše co ti řekl byla pravda až na jednu výjimku.", "Mozek sis nechal vymýt, ne kvůli infiltraci, ale kvůli tíze viny, kterou jsi nesl za zabíjení nevinných lidí", "Mrtvolu svého bratra jsi spálil a začal ses vydávat za Temného lorda.", "Vzhledem k tomu, že Temného lorda nikdo nikdy neviděl, nebyl v tom žádný problém", "Díky moci, kterou jsi tímto nabyl ses rozhodl páchat dobro a za tvé vlády země jenom prosperovala", "Konec - GOOD end - Frankie se stal výborným panovníkem"  );
          /*KONEC BAD OPĚT VRAH*/  Dialog dialog12 = new Dialog("Temný lord:\n'Výborná volba, bratře. Vítej zpět'", "Vrátil ses na trůn tyrana a vraha milionů lidí a pokračuješ ve vládě společně se svým bratrem, po čase sis na všechno vzpomněl a za svojí volbu jsi byl rád. ", "Konec - BAD end - Frankie opět vrahem" );






            //Odboj
            Dialog dialog14 = new Dialog("Všichni se ti začali postupně představovat", "Společně se všemi se ti představí i Alex.", "Dozvíš se, že Alexovi rodiče byli zabiti rukou Temného lorda a že netouží po ničem jiném než své rodiče pomstít.", "Každý člen odboje něco díky Temnému lordovi ztratil a každý touží po pomstě.", "Dále zjišťuješ, že jsi jediný co má vymytý mozek, všichni ostatní si na vše dokonale pamatují.", "Po dlouhém povídání jste udělali tábor a dohodli jste se, že ráno vyrazíte do bývalé lidské vesnice zkontrolovat, jestli někdo přežil.", "Vyrazili jste hned za svítání. Ve vesnici zjišťujete, že nezbyl ani jeden přeživší.", " Alex:\n'Vypadá to, že jsme poslední lidé v této zemi',\nřekl a podíval se na tebe, jakoby čekal, že k tomu něco řekneš.", "Ale vzhledem k tomu, že si nic nepamatuješ, nemáš žádné emoce. A proto tě jen zajímá kam se jde dál. ", "Frankie:\nKam se jde dál ?", "celý odboj jednohlasně rozhodne, že máš další destinaci vybrat ty, ale cíl má být Temný hrad a zneškodnení Temného lorda", "Co uděláš ?");



            //Elfí vesnice
            Dialog dialog15 = new Dialog("V Elfí vesnici potkáváte poměrně mírumilovné elfy, kteří se na tebe podivně dívají, jakoby tě znali.", "Když projíždíte okolo temné uličky, uslyšíš zaznít tvé jméno, sesedneš z koně a jdeš se sám kouknout odkud to zaznělo.", "V rohu stojí elf, který se na tebe podivně šklebí. 'Nazdar Frankie,' řekne elf.", "Elf:\nDám ti na výběr, buď přijmeš moji nabídku a nebo zhyneš společně se svým odbojem, jelikož sem jedou Spadlí.", "Co uděláš ?");
            Dialog dialog16 = new Dialog(true, player, new Enemy(player.level, "Delf_m", Enemy.Type.BASIC));
            /*KONEC NEUTRAL FRANKIE ODJEL*/ Dialog dialog17 = new Dialog("Elf:\nSkvělá volba, Frankie, v přístavu na tebe čeká loď, s ní odpluješ do jiné země, kde nevládne Temný lord.", "Zachoval ses jako zbabělec, ale zachránil sis život a nikdy se nedozvíš jak to dopadlo s Temným lordem, jeho armádou a tvými přateli v odboji", "KONEC - Frankie je zbabělec");



            //Skřetí vesnice
            Dialog dialog19 = new Dialog("Došel jste do Skřetí vesnice, kde vládne obří Orc, který má v otroctví pár lidských žen.", "Ženy se pro rozvoj lidské populace hodí.", "Co uděláš ?");

            Dialog dialog20 = new Dialog(true, player, new Enemy(player.level, "Ogre", Enemy.Type.BASIC));
           /*KONEC NEUTRAL ROZMNOŽOVÁNÍ*/Dialog dialog22 = new Dialog("Jelikož v odboji nebyla ani jedna žena, všichni uvítali jejich přítomnost a rozhodli se natrvalo zůstat", "KONEC - celý odboj zůstal a rozmnožoval se s ženami ve vesnici");
            Dialog dialog21 = new Dialog(true, player, new Enemy(player.level, "Ogre", Enemy.Type.BASIC));




            //Temný hrad
            Dialog dialog18 = new Dialog("Po boji se rychle přesunete k Temnému hradu, aby jste se vyhli dalším potížím.", "Vrata Temného hradu jsou dokořán otevřena, jakoby vás Temný lord očekávál", "Kde budeš Temného lorda hledat ?" );
            Dialog dialog23 = new Dialog("Tady není.", "Kam dál ?");
            Dialog dialog24 = new Dialog("Tady není.", "Kam dál ?");

            Dialog dialog25 = new Dialog("Jak scházíte do sklepení, vidíte Temného lorda sedět na svém trůnu", "Temný lord:\nNazdar Frankie", "Co uděláš ?");

            Dialog dialog26 = new Dialog(true, player, new Enemy(player.level, "Darklord", Enemy.Type.BASIC));

            //Temný hrad - konce
            /*KONEC GOOD TEMNÝ LORD PORAŽEN*/ Dialog dialog27 = new Dialog("Temný lord je poražen, existence lidí přestala být v ohrožení a ty se nikdy nedozvíš, proč Temný lord znal tvé jméno", "KONEC - Temný lord mrtev, lidi jsou zachráněni.");
            /*KONEC BAD LIDSTVO VYVRAŽDĚNO*/Dialog dialog28 = new Dialog("Temný lord vás všechny pobil a šance na záchranu lidstva je ztracená ", "KONEC - Bad end - lidstvo vyvražděno");
            /*KONEC BAD FRANKIE NA POPRAVU*/Dialog dialog29 = new Dialog("Temný lord\nAh .. Frankie, ty jsi mě zklamal", "Temný lord ti zabil celý odboj společně s Alexem a vyslal tě zpátky na popravu, bez šance na přežití", "KONEC - bad end - Frankie na popravu");

            Dialog dialogkonec = new Dialog();











            dialog1.moznost.Add(new Moznost("ano", dialog2));

            dialog1.moznost.Add(new Moznost("ne", dialog3));



            dialog2.moznost.Add(new Moznost("ano", dialog3));

            dialog2.moznost.Add(new Moznost("ano", dialog3));



            dialog3.moznost.Add(new Moznost("Utéct do lesa.", dialog5));

            dialog3.moznost.Add(new Moznost("Zůstat a bojovat po boku lidí,co tě zachránili.", dialog4));



            dialog4.moznost.Add(new Moznost("vyhrál jsi.", dialog13));

            dialog4.moznost.Add(new Moznost("prohrál jsi.", dialog3));


            dialog5.moznost.Add(new Moznost("Zabít všechny 'Zachránce'.", dialog6));

            dialog5.moznost.Add(new Moznost("Mírumilovně přijít k lidemco tě zachránili.", dialog14));


            dialog6.moznost.Add(new Moznost("Výhra", dialog7));

            dialog6.moznost.Add(new Moznost("Prohra", dialog5));


            dialog7.moznost.Add(new Moznost("Pokusit se utéct.", dialog8));

            dialog7.moznost.Add(new Moznost("Umlčit muže a zůstat.", dialog9));


            dialog9.moznost.Add(new Moznost("Zabít Temného lorda", dialog10));

            dialog9.moznost.Add(new Moznost("Přidat se k Temnému lordu", dialog12));


            dialog10.moznost.Add(new Moznost("Výhra", dialog11));

            dialog10.moznost.Add(new Moznost("Prohra", dialog9));







            dialog13.moznost.Add(new Moznost("Nezdají se ti, zabít všechny.", dialog6));

            dialog13.moznost.Add(new Moznost("Věříš jim, přidat se k odboji.", dialog14));


            //Elfí vesnice
            dialog14.moznost.Add(new Moznost("Jít přes Elfí vesnici.", dialog15));

            dialog14.moznost.Add(new Moznost("Jít přes Skřetí vesnici.", dialog19));



            dialog15.moznost.Add(new Moznost("Odmítnout nabídku.", dialog16));

            dialog15.moznost.Add(new Moznost("Přijmout nabídku.", dialog17));


            dialog16.moznost.Add(new Moznost("Výhra", dialog18));

            dialog16.moznost.Add(new Moznost("Prohra", dialog15));



            //Skřetí vesnice
            dialog19.moznost.Add(new Moznost("Osvobodit ženy a zůstat.", dialog20));
            dialog19.moznost.Add(new Moznost("Osvobodit ženy a pokračovat v cestě.", dialog21));


            dialog20.moznost.Add(new Moznost("Výhra", dialog22));
            dialog20.moznost.Add(new Moznost("Prohra", dialog19));

            dialog21.moznost.Add(new Moznost("Výhra", dialog18));
            dialog21.moznost.Add(new Moznost("Prohra", dialog19));



            //Temný hrad
            dialog18.moznost.Add(new Moznost("Vstupní hala", dialog23));
            dialog18.moznost.Add(new Moznost("Stáje", dialog24));

            dialog23.moznost.Add(new Moznost("Sklepení", dialog25));
            dialog23.moznost.Add(new Moznost("Stáje", dialog24));

            dialog24.moznost.Add(new Moznost("Sklepení", dialog25));
            dialog24.moznost.Add(new Moznost("Vstupní hala", dialog23));

            dialog25.moznost.Add(new Moznost("Bezmyšlenkovitě rozhodneš zaútočít", dialog26));
            dialog25.moznost.Add(new Moznost("Rozmyslet si jak reagovat na oslovení tvým jménem", dialog29));

            // Temný hrad - konce
            dialog26.moznost.Add(new Moznost("Výhra", dialog27));
            dialog26.moznost.Add(new Moznost("Prohra", dialog28));



            //Konec











            currentdialog = dialog1;
            if (dialog != null)
            {
                currentdialog = dialog;
            }
            loaddialog();


        }

        private void loaddialog()
        {
            if (currentdialog.Combat != null)

                NavigationService.Navigate(new Combat(currentdialog));
            else {
                question.Text = currentdialog.texty[index];

                if (currentdialog.moznost.Count > 1)
                {
                    bttn1.Content = currentdialog.moznost[0].decision;
                    bttn2.Content = currentdialog.moznost[1].decision;

                }
                if (currentdialog.moznost.Count == 0)
                {
                    bttn1.Visibility = Visibility.Hidden;
                    bttn2.Visibility = Visibility.Hidden;

                    if (index >= currentdialog.texty.Count - 1)
                    {
                        bttn4.Visibility = Visibility.Visible;
                    }


                }
                

            }


        }

        private void Next_Dialog(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string decision = button.Content.ToString();


            Moznost combat = currentdialog.moznost.Find(moz => moz.dialog.Combat != null);
            Moznost moznost = currentdialog.moznost.Find(moz => moz.decision == decision);

            if (combat != null)
            {
                if (combat != moznost)
                {

                    player.level++;


                }
            }




            currentdialog = moznost.dialog;


            bttn3.IsEnabled = true;
            bttn1.Visibility = Visibility.Hidden;
            bttn2.Visibility = Visibility.Hidden;
            index = 0;
            loaddialog();

        }

        private void Next_Text(object sender, RoutedEventArgs e)
        {
            index++;
            if (index >= currentdialog.texty.Count - 1)
            {
                bttn3.IsEnabled = false;
                bttn1.Visibility = Visibility.Visible;
                bttn2.Visibility = Visibility.Visible;
            }


            loaddialog();


        }

        private void End_Game(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
