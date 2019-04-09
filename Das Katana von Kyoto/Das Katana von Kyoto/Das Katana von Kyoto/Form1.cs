using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Das_Katana_von_Kyoto
{
    public partial class Form1 : Form
    {

        public static int game = 1;
        public static int yen = 50;
        public static int wahl1 = 0;
        public static int wahl2 = 0;
        public static int wurf = 0;
        public static int würfelnyou = 0;
        public static int würfelnenemy = 0;
        public static int gesundheit = 5;
        public static int stärke = 11;
        public static int angriff = 11;

        public Form1()
        {
            InitializeComponent();
            Playgame();
            button2.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Geldgameover()
        {
            if (yen <= 0)
            {
                MessageBox.Show("Du hast ken Geld mehr. Du verzweifelst und begehst Suizid. GAME OVER", "GAME OVER", MessageBoxButtons.OK);
                this.Close();
            }
        }

        public void GameOver()
        {
            MessageBox.Show("Du hast eine falsche Entscheidung getroffen und wurdest getötet. GAME OVER", "GAME OVER", MessageBoxButtons.OK);
            this.Close();
        }

        public void End()
        {
            MessageBox.Show("Danke das du dieses Spiel gespielt hast. Es wurde von dem Entwickler Alexander Lehr programmiert. Danke", "Spiel Ende", MessageBoxButtons.OK);
            this.Close();
        }

        public void Playgame ()
        {
            switch (game)
            {
                case 1:
                    rtbtext.Text = "Du schläfst und träumst von einem Katana mit einer Klinge aus Kristall. Plötzlich wachst du auf und hörst eine leise Stimme in deinem Kopf. Sie sagt, dass du heute auf den Stadtplatz gehen sollst. Dies sei dein Schicksal.";
                    tbwahl1.Text = "Du gehst zum Stadtplatz und guckst dich um.";
                    tbwahl2.Text = "Du bist verwirrt wegen der Stimme und gehst zum Stadtplatz, aber versteckst dich dort.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 2;
                    wahl2 = 3;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 2:
                    rtbtext.Text = "Du bist am Stadtplatz von Kyoto angekommen. Er ist sehr groß und es tummeln sich sehr viele Menschen dort. Plötzlich hörst du die Stimme wieder, welche sagt, dass dich in 10 Minuten ein Mädchen namens Sakura ansprechen wird und eine Aufgabe für dich hat.";
                    tbwahl1.Text = "Ahh..., ich bin doch kein Abenteurer. Du läufst weg.";
                    tbwahl2.Text = "Hmm..., man kann ja mal versuchen ihr zu helfen. Du wartest.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 4;
                    wahl2 = 5;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 3:
                    rtbtext.Text = "Du versteckst dich auf dem Stadtplatz von Kyoto. Er ist sehr groß und es tummeln sich sehr viele Menschen dort. Plötzlich erscheint die seltsame Stimme wieder und sagt, dass du keine Angst haben musst und dich ein Mädchen namens Sakura wegen einer Aufgabe in 10 Minuten ansprechen wird";
                    tbwahl1.Text = "Ahh..., du bekommst noch mehr Angst und flüchtest in Richtung deines Hauses.";
                    tbwahl2.Text = "Hmm..., man kann ja mal versuchen ihr zu helfen. Du wartest.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 4;
                    wahl2 = 5;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 4:
                    rtbtext.Text = "Du flüchtest in Richung deines Hauses aber vor dir erstrahlt ein helles Licht. Du stoppst und und ein Mädchen mit langen schwarzen Haaren tritt aus dem Licht. Sie kommt auf dich zu und fragt dich warum du geflüchtet bist. Darauf sagt sie, dass sie möchte, dass du auf die Suche nach dem Crystal Katana gehen musst, denn die Seele der rechtmäßigen Prinzessin Itaya wurde in dem Stein von Beruth versiegelt und nur das Katana kann den Stein zerstören und sie befreien.";
                    tbwahl1.Text = "Wie? Die jetzige Prinzessin, die bald über Japan herrscht, ist nicht echt?";
                    tbwahl2.Text = "Erzähle keinen Stuss. Das was du sagst kann doch nicht wahr sein, oder?";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 6;
                    wahl2 = 7;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 5:
                    rtbtext.Text = "Du wartest 10 Minuten und ehe du dich versiehst, sind alle Menschen verschwunden und irgendwie ist die Umgebung verzerrt. Plötzlich erscheint eine Lichtkugel am Himmel, die vor dir landet. Ein Mädchen mit langen Schwarzen Haaren tritt aus dem Licht und sagt, dass sie Sakura heißt. 10 Sekunden geschieht nichts. Aufeinmal sagt sie, dass du auf die Suche nach dem Crystal Katana gehen musst, denn die Seele der rechtmäßigen Prinzessin Itaya wurde in dem Stein von Beruth versiegelt und nur das Katana kann den Stein zerstören und sie befreien.";
                    tbwahl1.Text = "Das ist schlimm, wenn die jetzige Prinzessin nicht echt ist, herrscht ja bald die Falsche, oder?";
                    tbwahl2.Text = "Ne, erzähle doch keinen Unsinn. Das ist auf keinen Fall wahr, oder?";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 6;
                    wahl2 = 7;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 6:
                    rtbtext.Text = "Sakura sagt darauf, dass es leider wahr ist und die jetzige Prinzessin die Tochter des Dämonenkönigs Jintai ist und du getestet werden musst. Sie beschwört einen Schatten. Er greift dich an!";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 0;
                    wahl2 = 0;
                    stärke = 3;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbstärkegeg.Text = Convert.ToString(stärke);
                    tbleben.Text = Convert.ToString(gesundheit);
                    button1.Enabled = false;
                    button2.Enabled = true;
                    wurf = 8;
                    Geldgameover();
                    break;

                case 7:
                    rtbtext.Text = "Sakura sagt: \"Man kann es nicht verleugnen die Zeichen sind überall. Die jetzige Prinzessin ist eine Fälschung. Sie ist die Tochter des Dämonenkönigs Jintai. Du musst vorbereitet sein, darum teste ich dich jetzt.\" Sie beschwört einen Schatten. Er greift dich an!";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 0;
                    wahl2 = 0;
                    stärke = 3;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbstärkegeg.Text = Convert.ToString(stärke);
                    tbleben.Text = Convert.ToString(gesundheit);
                    button1.Enabled = false;
                    button2.Enabled = true;
                    wurf = 8;
                    Geldgameover();
                    break;

                case 8:
                    rtbtext.Text = "Sakura schaut dich strahlend an und sagt:\"Du konntest einen Schatten der Finsternis besiegen. In dir fließt fürwahr besonders Blut.\" Sie atmet tief durch und sagt: \"Ich werde dich begleiten, denn ich bin eine Magierin und kann dich so unterstützen. Aber du entscheidest den Weg, denn du hast die Gabe. Willst du zuerst in Richtung Norden, zum Gebirge der Meditation, oder willst du Richtung Osten, zum Wald der Seelen?\"";
                    tbwahl1.Text = "Ich wusste garnicht, dass ich so besonders bin. Ich glaube, dass wir zum Gebirge gehen sollten. Da sind die Mönche.";
                    tbwahl2.Text = "Habe ich das gerade wirklich gemacht? Ich glaube wir sollten die Geister um Hilfe bitten. Ich wäre für den Wald.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 25;
                    wahl2 = 9;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 9:
                    rtbtext.Text = "Ihr seid auf dem Weg zum Wald der Seelen. Ihr seid schon 4 Stunden am Laufen. Plötzlich erscheint ein Kleines Dorf. Es sieht sehr altertümlich aus. Sakura fragt dich, ob du dahin möchtest.";
                    tbwahl1.Text = "Du überlegst. Hmm..., ich glaube es wäre sinnvoll unsere Vorräte aufzustocken. Gehen wir dort hin.";
                    tbwahl2.Text = "Du überlegst. Hmm..., ich glaube es wäre besser weiter zu gehen. Wir wissen nicht, ob sie uns freundlich gesinnt sind.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 10;
                    wahl2 = 16;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 10:
                    rtbtext.Text = "Ihr geht zum Dorf und schaut euch um. Ihr seht eine Taverne und tretet ein. Ihr bestellt ein Glas Sake und der Wirt sagt: \"Ihr seht wie Abenteurer aus. Wollt ihr dieses Schwert kaufen? Es kostet nur 10 Yen?\"";
                    tbwahl1.Text = "Du überlegst. Es wäre sinvoll sich besser auszurüsten. Dieses \"Buttermesser\" taugt zu nichts. Ich nehme es.";
                    tbwahl2.Text = "Du überlegst. Nein wir müssen sparen. Wir haben nur wenig Geld und vielleicht brauchen wir das irgendwann noch.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 11;
                    wahl2 = 12;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 11:
                    rtbtext.Text = "Du kaufst das Schwert für 10 Yen. (Dein Angriff steigt um 1) Als ihr die Taverne verlasst, seht ihr eine arme Frau auf dem Boden liegen. Zwei vermummte Personen schlagen auf sie ein. Du eilst ihr zu Hilfe!";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    yen = yen - 10;
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 0;
                    wahl2 = 0;
                    angriff = angriff + 1;
                    stärke = 4;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbstärkegeg.Text = Convert.ToString(stärke);
                    button1.Enabled = false;
                    button2.Enabled = true;
                    wurf = 13;
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 12:
                    rtbtext.Text = "Du kaufst das Schwert nicht und ihr verlasst die Tavevrne. Als ihr die Taverne verlasst, seht ihr eine arme Frau auf dem Boden liegen. Zwei vermummte Personen schlagen auf sie ein. Du eilst ihr zu Hilfe!";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    yen = yen - 10;
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 0;
                    wahl2 = 0;
                    stärke = 4;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbstärkegeg.Text = Convert.ToString(stärke);
                    button1.Enabled = false;
                    button2.Enabled = true;
                    wurf = 13;
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 13:
                    rtbtext.Text = "Du gewinnst gegen die Gestalten. Du hilfst der armen Frau hoch und sie sagt: \"Danke werter Herr, sie sind ein Held. Diese vermummten Personen sind Ninjas aus dem Schloss des Kaisers. Man sagt, dass die Königsfamilie sich seit einem Monat sehr seltsam verhält und sie ihre Schergen auf uns hetzen, um uns mundtot zu machen!\"";
                    tbwahl1.Text = "Das ist ja schlimm. Überhaubt, weißt du was über das Crystall Katana? Wir benötigen dieses dringend.";
                    tbwahl2.Text = "Du denkst *Hmm.., so schlimm ist es schon geworden. Wir brauchen das Katana dringend*. Hoffe es geht dir besser. Überhaubt, weißt du was über das Crystall Katana.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 14;
                    wahl2 = 14;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 14:
                    rtbtext.Text = "Die arme Frau guckt verwirrt und sagt: \"Von so einem Katana habe ich noch nie gehört, aber vielleicht wissen die Geister mehr. Ihr solltet sie im Wald aufsuchen.\" Sie überlegt ein paar Minuten, gibt dir einen seltsamen Stein und sagt: \"Das ist ein Stein des Lebens, wenn du sterben solltest, regeneriert sich dein Körper komplett und deine Seele fährt wieder in deinen Körper ein.\"";
                    tbwahl1.Text = "Danke, das ist sehr nett. Ich werde Ihn weise benutzen.";
                    tbwahl2.Text = "-";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 15;
                    wahl2 = 0;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 15:
                    rtbtext.Text = "Ihr verlasst das Dorf und geht in Richtung Wald. ... Nach zwei weiteren Stunden erreicht ihr den Wald. Ihr fühlt, dass ihr beobachtet werdet.";
                    tbwahl1.Text = "Sakura, irgendwas beobachtet mich. Kennst du einen Aufspürzauber?";
                    tbwahl2.Text = "Du ignorierst das Gefühl und gehst weiter.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 17;
                    wahl2 = 0;
                    gesundheit = gesundheit + 1;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 16:
                    rtbtext.Text = "Ihr geht nicht ins Dorf, sondern direkt zum Wald. ... Nach zwei weiteren Stunden erreicht ihr den Wald. Ihr fühlt, dass ihr beobachtet werdet.";
                    tbwahl1.Text = "Sakura, irgendwas beobachtet mich. Kennst du einen Aufspürzauber?";
                    tbwahl2.Text = "Du ignorierst das Gefühl und gehst weiter.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 17;
                    wahl2 = 21;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 17:
                    rtbtext.Text = "Sakura wirkt einen Aufspührzauber. Ein Lichtstrahl weist zu einer Lichtung. Ihr geht hin. Auf der Lichtung sitzt ein kleines Wesen, welches aussieht, wie eine Katze, nur menschlicher, jedoch kleiner als ein Erwachsender. Es könnte noch ein Kind sein. Es kommt schüchtern auf dich zu und fragt: \"Was wollt ihr in diesem Wald? Dieser ist ein Ort für uns Katzengeister. Mein Vater wird nicht erfreut sein, dass Menschen in unseren Wald gekommen sind.\"";
                    tbwahl1.Text = "Wir wollen euch nicht schaden. Wir suchen das Crystal Katana um Japan zu retten.";
                    tbwahl2.Text = "Du machst mir keine Angst. Wir sind auf der Suche nach etwas Wichtigem. Niemand hält uns auf.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 19;
                    wahl2 = 18;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 18:
                    rtbtext.Text = "Das Kind ruft die Wachen. Du kannst nicht flüchten. Sie greifen dich an und richten dich hin.";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    GameOver();
                    break;

                case 19:
                    rtbtext.Text = "Das Kind erschrickt und sagt erstaunt: \"D... D... Das Crystal Katana. Das ist ein heiliges Schwert, welches nur der auserwählte Samurai führen kann. Komm, mein Vater will dich bestimmt sehen.\"";
                    tbwahl1.Text = "Du gehst mit dem Jungen und bist gespannt auf die Geschichte des Katanas";
                    tbwahl2.Text = "-";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 20;
                    wahl2 = 0;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 20:
                    rtbtext.Text = "Ihr geht eine Zeit durch den Wald. Plötzlch siehst du einen See, an dem ein älteres katzenähnliches Wesen mit einem langen Bart steht. Als ihr vor ihm steht sagt er: \"Ich weiß, warum du hier bist. Du bist derjenige, der von der Seele der Prinzessin geleitet wird. Du suchst das Katana um Sie zu befreien. Das ist aber noch nicht alles. Du musst den Dämonenkönig Jintai töten. Dies ist dein Schicksal.\"";
                    tbwahl1.Text = "Wenn dies mein Schicksal ist, kann ich mich dem nicht wiedersetzen, aber ich habe keine Kampferfahrung.";
                    tbwahl2.Text = "Ähhh..., ich den Dämonenkönig töten? Das ist doch wohl ein Witz, oder? Ich kann das nicht.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 24;
                    wahl2 = 23;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 21:
                    rtbtext.Text = "Ihr ignoriert das Gefühl und geht weiter. Nach einiger Zeit seht ihr einen See, an dem ein älteres katzenähnliches Wesen mit einem langen Bart steht. Plötzlich greifen dich Wachen an. Du wehrst dich.";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 0;
                    wahl2 = 0;
                    stärke = 6;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbstärkegeg.Text = Convert.ToString(stärke);
                    button1.Enabled = false;
                    button2.Enabled = true;
                    wurf = 22;
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 22:
                    rtbtext.Text = "Du gewinnst gegen die Wachen. Plötzlich ertönt eine tiefe, aber freundliche Stimme, die sagt: \"Lasst sie durch. Er ist etwas Besonderes!\" Als ihr vor ihm steht sagt er: \"Ich weiß, warum du hier bist. Du bist derjenige, der von der Seele der Prinzessin geleitet wird. Du suchst das Katana um sie zu befreien. Das ist aber noch nicht alles. Du musst den Dämonenkönig Jintai töten. Dies ist dein Schicksal.\"";
                    tbwahl1.Text = "Wenn dies mein Schiksal ist, kann ich mich dem nicht wiedersetzen, aber ich habe keine Kampferfahrung.";
                    tbwahl2.Text = "Ähhh..., ich den Dämonenkönig töten? Das ist doch wohl ein Witz, oder? Ich kann das nicht.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 24;
                    wahl2 = 23;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 23:
                    rtbtext.Text = "Der alte Katzengeist spricht ernst: \"Du weist garnicht was du da sagst. DU bist der einzige der ihn aufhalten kann. Du bist der einzige der ihn aufhalten kann.\"";
                    tbwahl1.Text = "Wenn das so ist und ich die einzige Hoffnug bin werde ich es versuchen. Ich brauche aber Kampferfahrung";
                    tbwahl2.Text = "";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 24;
                    wahl2 = 0;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 24:
                    rtbtext.Text = "Der Älteste fängt an zu lächeln und sagt: \"Du brauchst keine Kampferfahrung. Du hast sie bereits, denn bist die Reinkanation vom heiligen Samurai des schicksals der das Königshaus schützte. Du bist der rechtmäßige Träger des Crystal Katanas.\"";
                    tbwahl1.Text = "Ich kann mich an nichts erinnern kannst du mir mehr über meine Vergangenheit erzählen.";
                    tbwahl2.Text = "Wenn ich der rechtmäsige Erbe des Katanas bin. Wo ist es.";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 27;
                    wahl2 = 28;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 25:
                    rtbtext.Text = "Du bist auf dem weg zu den Bergern. Nach 2 Stunden Fußmarsch erscheint eine schwarze unförmige Mauer aus einer Supstanz die du nicht kennst. Sakura erschaudert und sagt: \"Wir müssen weg. SOFORT Das ist der Anfang des Dämonenreiches. Ich öffne ein Portal nach Kyoto. Komm\"";
                    tbwahl1.Text = "Du hörst auf Sakura, gehst zurück nach Kyoto und ihr läuft in richtung Wald";
                    tbwahl2.Text = "Du ignorirst Sakuras Warnung und versuchst durch das Dunkle Tor zu kommen";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 9;
                    wahl2 = 26;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 26:
                    rtbtext.Text = "Du berührst du Mauer und eine starke Kraft rerisßt dich auseinander";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    GameOver();
                    break;

                case 27:
                    rtbtext.Text = "Er atmat tief durch und sagt: \"In deinem früheren Leben hast du den Eid gegenüber dem Königshaus abgelegt du hast geschwohren in diesem Leben und in allen Folgenden. Du hast ein Fragment deiner Seele genommen und in dein Katana geleitet. So entstand das Crystal Katana. Als du gestorben verschwand das Katana. Ich glaube das Katana ist wieder mit deiner Seele verschmolzen. Wir müssen das Ritual nochmal wiederholen.\"";
                    tbwahl1.Text = "Ok wenn das so ist Machen wir das so.";
                    tbwahl2.Text = "";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 29;
                    wahl2 = 0;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 28:
                    rtbtext.Text = "Der Älteste sagt nachdenklich: \"Das Katana ist in deinem Körper, denn als du dem Königshaus die ewige Treue in aller deiner Leben geschworen hattest, hast du aus einem Teil deiner Seele das Katana erschaffen. Wir müssen das Ritual wiederholen.\"";
                    tbwahl1.Text = "Ok wenn das so ist Machen wir das so.";
                    tbwahl2.Text = "";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 29;
                    wahl2 = 0;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 29:
                    rtbtext.Text = "Der Älteste erhebt sich und du fällst auf die Knie. Er sagt: \"Schwörst du in deinem jetzigen Leben und in allen Folgenden Dem Königshaus und dem Kaiser ewige treue und schützt seine Famlie mit seinem Leben\"";
                    tbwahl1.Text = "Ja ich schwöre";
                    tbwahl2.Text = "Nö";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 31;
                    wahl2 = 30;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 30:
                    rtbtext.Text = "Das Ritual schlägt fehl. Du merkst wie dein Körper innerlich zerreist. Du bist Tot";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    GameOver();
                    break;

                case 31:
                    rtbtext.Text = "\"Schwörst du alle deine Begierden und Wünsche zum wohl den Kaisers abzulegen\"";
                    tbwahl1.Text = "Ja ich schwöre";
                    tbwahl2.Text = "Nö";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 32;
                    wahl2 = 30;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 32:
                    rtbtext.Text = "\"Schwörst du die Prinzessin zu retten und damit Japan wieder in den Frieden zu leiten\"";
                    tbwahl1.Text = "Ja ich schwöre";
                    tbwahl2.Text = "Nö";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 33;
                    wahl2 = 30;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 33:
                    rtbtext.Text = "\"So sei es. Jetzt bist du wieder der heilige Samurai.\" Plötzlich strahlt ein helles Licht aus deinem Körper. Du weist wieder alles aus deinem Vorherigem Leben. Auf ein mal erscheint ein Katana aus Kristall vor dir.";
                    tbwahl1.Text = "Du greifst das Katana";
                    tbwahl2.Text = "Du nimst das Katana nicht";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 34;
                    wahl2 = 30;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 34:
                    rtbtext.Text = "Eine mächtige Kraft durchströmt dich als du das Katana in der hand hälst. (Dein Angrif steigt um 5!!!) Sakura sagt: \"Jetzt stürmen wir die gegnerische Festung. Los gehts.\" Sakrua öffnet ein Portal.";
                    tbwahl1.Text = "Du gehst durch das Portal";
                    tbwahl2.Text = "";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 35;
                    wahl2 = 0;
                    angriff = angriff + 5;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 35:
                    rtbtext.Text = "Als du durch das Portal trittst befindest du dich im Tronsahl des Kaisers. Aber alles ist voller Dämonen. Die Wachen Greifen dich an.";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 0;
                    wahl2 = 0;
                    stärke = 8;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbstärkegeg.Text = Convert.ToString(stärke);
                    button1.Enabled = false;
                    button2.Enabled = true;
                    wurf = 36;
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 36:
                    rtbtext.Text = "Als du alle Wachen besiegt hast stehst du vor dem Dämonenkönig Jintai. Er sagt: \"Du bist weit gekommen aber hier wirst du scheitern, du Wicht. Du wirst die Prinzessin niemal befreiene. Ich werde dich bezwingen und nicht nur der Herrscher von Japan sein sondern von der ganzen Welt.\" Er greift an";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 0;
                    wahl2 = 0;
                    stärke = 12;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbstärkegeg.Text = Convert.ToString(stärke);
                    button1.Enabled = false;
                    button2.Enabled = true;
                    wurf = 37;
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 37:
                    rtbtext.Text = "Jintai schreit: \"Ich habe dich unterschätzt aber jetzt wirst du meine ganze macht Kennenlernen.\" Jintai leuchtet in einem schwarzen Licht auf. Sein Körper wird zu einer schwarzen unförmigen Masse. Jintai sagt erböst: \"Ich bin das Böse der Welt. Alle bösen Taten und Gedanken der Menschen sind manifestiert und so bin ich entstanden. Solange es Menschen gibt werde ich existieren.\" Jintai greift an";
                    tbwahl1.Text = "-";
                    tbwahl2.Text = "-";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 0;
                    wahl2 = 0;
                    stärke = 14;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbstärkegeg.Text = Convert.ToString(stärke);
                    button1.Enabled = false;
                    button2.Enabled = true;
                    wurf = 38;
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 38:
                    rtbtext.Text = "Dein Schwert leuchtet auf und du greifst ein letztes am Jintei an. Er schreit und löst sich in einem hellen Lichtblitz auf. Alles im Schloss wird wieder normal die Menschen und Wachen erwachen aus ihrem Schlaf. Der Kaiser und seine Frau erwachen und der Kaiser sagt: \"Danke das du diese Welt gerettet hast. Aber Jintai wird wiederkommen. Nicht heute und auch nicht morgen aber so will es das Schiksal. Aber du musst noch meine Tochter retten.\" Er fürt dich in einen Raum mit einem Riesigen Felden in der Mitte. Er sagt: \"Das ist der Stein von Beruth du musst ihn zerschalgen und meine tochter Itaya befreien. Das ist dein Schiksal\"";
                    tbwahl1.Text = "Du zerschlägst den Stein";
                    tbwahl2.Text = "";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 39;
                    wahl2 = 0;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 39:
                    rtbtext.Text = "Als du versuchst den Stein zu zerschlagen verbrauchst du deine Ganze Lebensenergie. Plötzlich zerschpringt das Katana und du fällst zu Boden. Itaya erscheint und spricht zu dir: \"Es war dein Schicksal hier zu sterben aber du hast mich gerettet und jetzt möchte ich dich retten. ich werde wie vor 1000 Jahren deine Seele in die Zukunft schicken und du wirst wieder Leben.\" Itaya wirkt das Ritual.";
                    tbwahl1.Text = "Du gest dem Licht nach und wirst wiederbelebt";
                    tbwahl2.Text = "";
                    tbyen.Text = Convert.ToString(yen);
                    wahl1 = 40;
                    wahl2 = 0;
                    tbangriff.Text = Convert.ToString(angriff);
                    tbleben.Text = Convert.ToString(gesundheit);
                    Geldgameover();
                    break;

                case 40:
                    End();
                    break;

                default:

                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbwahl1.Checked == true)
            {
                game = wahl1;
            }
            else
            if (rbwahl2.Checked == true)
            {
                game = wahl2;
            }
            else
            {
                MessageBox.Show("Keine Wahl ausgewählt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Playgame();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            neuwürfeln:
            Random random = new Random();
            würfelnyou = random.Next(1, angriff);
            würfelnenemy = random.Next(1, stärke);

            tbwurfdu.Text = Convert.ToString(würfelnyou);
            tbwurfgegner.Text = Convert.ToString(würfelnenemy);

            if (würfelnyou < würfelnenemy)
            {
                if (gesundheit > 0)
                {
                    MessageBox.Show("Du wurdest besiegt aber wie durch ein wunder kehrt deine Seele in deinen Körper zurück. (Du würfelst neu)", "Besiegt", MessageBoxButtons.OK);
                    gesundheit = gesundheit - 1;
                    tbleben.Text = Convert.ToString(gesundheit);
                    goto neuwürfeln;
                }
                else
                if (gesundheit <= 0)
                {
                    MessageBox.Show("Du wurdest getötet und deine Seele wurde zerschmettert. GAME OVER", "Besiegt", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            if (würfelnyou > würfelnenemy)
            {
                game = wurf;
                button2.Enabled = false;
                button1.Enabled = true;
                tbstärkegeg.Text = "";
                Playgame();
            }
            else
            if (würfelnyou == würfelnenemy)
            {
                MessageBox.Show("Ihr habt ein Unentschieden. Es wird nochmal gewürfelt.", "Unentschieden", MessageBoxButtons.OK);
                goto neuwürfeln;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Willst du wirklich resetten", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                game = 1;
                Playgame();
            }
            else
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game = 38;
            angriff = 20;
            tbangriff.Text = Convert.ToString(angriff);
            Playgame();
        }
    }
}
