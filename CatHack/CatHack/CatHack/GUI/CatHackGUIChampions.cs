using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatHack.GUI
{
    public partial class CatHackGUIChampions : Form
    {
        private bool mouseDown;
        private Point offset;

        private static string selectedChampion;
        private static float windupPercent;
        private static float bWindupTime;
        private static float windupModifier;

        private readonly string aphelios = "https://1.bp.blogspot.com/-R5ozICNl7AY/Xd2iaJ1x8wI/AAAAAAABb1c/Lkeeq4TPd7c7Hn2ThLeJe1fDE8dq5p2LgCLcBGAsYHQ/s1600/523.png";
        private readonly string ashe = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/4/4a/AsheSquare.png/revision/latest/scale-to-width-down/120?cb=20170728180206";
        private readonly string azir = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/f/f7/AzirSquare.png/revision/latest/scale-to-width-down/120?cb=20170728181650";
        private readonly string bard = "https://static.u.gg/assets/lol/riot_static/10.25.1/img/champion/Bard.png";
        private readonly string caitlyn = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/e/e6/CaitlynSquare.png/revision/latest/scale-to-width-down/120?cb=20170801175326";
        private readonly string corki = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/3/3d/CorkiSquare.png/revision/latest/scale-to-width-down/120?cb=20170801184703";
        private readonly string draven = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/d/d7/DravenSquare.png/revision/latest/scale-to-width-down/120?cb=20170801201235";
        private readonly string ezreal = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/c/c3/EzrealSquare.png/revision/latest/scale-to-width-down/120?cb=20170801212628";
        private readonly string gnar = "https://static.wikia.nocookie.net/leagueoflegends/images/2/2d/Gnar_OriginalSquare.png/revision/latest/scale-to-width-down/340?cb=20160526212623";
        private readonly string jayce = "https://static.wikia.nocookie.net/leagueoflegends/images/d/de/Jayce_OriginalSquare.png/revision/latest?cb=20160526212746";
        private readonly string jinx = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/e/e2/JinxSquare.png/revision/latest/scale-to-width-down/120?cb=20170802020615";
        private readonly string kaisa = "https://2.bp.blogspot.com/-D9B7VI6NQ80/Wo3UldSXIsI/AAAAAAAA5e4/a0M9fo4_vcUmsdWvfgalyJOR9Vs6vW1EQCEwYBhgL/s1600/145.png";
        private readonly string kalista = "https://static.wikia.nocookie.net/leagueoflegends/images/4/4d/Kalista_OriginalSquare.png/revision/latest?cb=20170401005336";
        private readonly string kayle = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/b/bd/KayleSquare.png/revision/latest/scale-to-width-down/120?cb=20190918193910";
        private readonly string kennen = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/6/69/KennenSquare.png/revision/latest/scale-to-width-down/120?cb=20170802030342";
        private readonly string kindred = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/6/6e/KindredSquare.png/revision/latest/scale-to-width-down/120?cb=20170802031055";
        private readonly string kogmaw = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/4/45/Kog%27MawSquare.png/revision/latest/scale-to-width-down/120?cb=20170802031916";
        private readonly string lucian = "https://img.rankedboost.com/wp-content/plugins/league/assets/champion-icons/Lucian-Icon.png";
        private readonly string missfortune = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/9/9d/MissFortuneSquare.png/revision/latest/scale-to-width-down/120?cb=20170802061243";
        private readonly string neeko = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/8/88/NeekoSquare.png/revision/latest/scale-to-width-down/120?cb=20181124185830";
        private readonly string soraka = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/8/8d/SorakaSquare.png/revision/latest/scale-to-width-down/120?cb=20170802134038";
        private readonly string quinn = "https://img.rankedboost.com/wp-content/plugins/league-of-legends-wild-rift/assets/champion-icons/Quinn-Icon.png";
        private readonly string samira = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/b/b3/SamiraSquare.png/revision/latest/scale-to-width-down/120?cb=20200830082811";
        private readonly string sivir = "https://img.rankedboost.com/wp-content/plugins/league/assets/champion-icons/Sivir-Icon.png";
        private readonly string teemo = "https://static.wikia.nocookie.net/leagueoflegends/images/9/9c/Teemo_OriginalSquare.png/revision/latest?cb=20150402221254";
        private readonly string tristana = "https://acqwmovtio.cloudimg.io/v7/https://ddragon.leagueoflegends.com/cdn/10.25.1/img/champion/Tristana.png?h=120";
        private readonly string twitch = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/7/79/TwitchSquare.png/revision/latest/scale-to-width-down/120?cb=20170802161732";
        private readonly string twistedfate = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/f/fb/Twisted_FateSquare.png/revision/latest/scale-to-width-down/120?cb=20170802161630";
        private readonly string varus = "https://acqwmovtio.cloudimg.io/v7/https://ddragon.leagueoflegends.com/cdn/10.25.1/img/champion/Varus.png?h=120";
        private readonly string vayne = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/9/95/VayneSquare.png/revision/latest/scale-to-width-down/120?cb=20170802170334";
        private readonly string xayah = "https://img.rankedboost.com/wp-content/plugins/league/assets/champion-icons/Xayah-Icon.png";
        private readonly string zilean = "https://static.wikia.nocookie.net/lolesports_gamepedia_en/images/a/ac/ZileanSquare.png/revision/latest/scale-to-width-down/120?cb=20170802185212";

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public CatHackGUIChampions()
        {
            InitializeComponent();
            championBox.SelectedIndex = Properties.Settings.Default.selectedChamp;
            System.Diagnostics.Debug.WriteLine(getWindupPercent());

            if (championBox.SelectedIndex == 0)
            {
                windupPercent = 15.333f;
                bWindupTime = 0.64f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = aphelios;
            }
            if (championBox.SelectedIndex == 1)
            {
                windupPercent = 21.93f;
                bWindupTime = 0.658f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = ashe;
            }
            if (championBox.SelectedIndex == 2)
            {
                windupPercent = 15.625f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = azir;
            }
            if (championBox.SelectedIndex == 3)
            {
                windupPercent = 18.75f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = bard;
            }
            if (championBox.SelectedIndex == 4)
            {
                windupPercent = 17.708f;
                bWindupTime = 0.681f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = caitlyn;
            }
            if (championBox.SelectedIndex == 5)
            {
                windupPercent = 10.00f;
                bWindupTime = 0.638f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = corki;
            }
            if (championBox.SelectedIndex == 6)
            {
                windupPercent = 15.614f;
                bWindupTime = 0.679f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = draven;
            }
            if (championBox.SelectedIndex == 7)
            {
                windupPercent = 18.839f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = ezreal;
            }
            if (championBox.SelectedIndex == 8)
            {
                windupPercent = 14.6f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = gnar;

            }
            if (championBox.SelectedIndex == 9)
            {
                windupPercent = 9.5f;
                bWindupTime = 0.658f;
                windupModifier = 0.005f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = jayce;
            }
            if (championBox.SelectedIndex == 10)
            {
                windupPercent = 16.875f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = jinx;
            }
            if (championBox.SelectedIndex == 11)
            {
                windupPercent = 16.108f;
                bWindupTime = 0.644f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kaisa;
            }
            if (championBox.SelectedIndex == 12)
            {
                windupPercent = 36.000f;
                bWindupTime = 0.694f;
                windupModifier = 0.75f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kalista;
            }
            if (championBox.SelectedIndex == 13)
            {
                windupPercent = 19.355f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kayle;
            }
            if (championBox.SelectedIndex == 14)
            {
                windupPercent = 20.00f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kennen;
            }
            if (championBox.SelectedIndex == 15)
            {
                windupPercent = 17.544f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kindred;
            }
            if (championBox.SelectedIndex == 16)
            {
                windupPercent = 16.622f;
                bWindupTime = 0.665f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kogmaw;
            }
            if (championBox.SelectedIndex == 17)
            {
                windupPercent = 15.00f;
                bWindupTime = 0.638f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = lucian;
            }
            if (championBox.SelectedIndex == 18)
            {
                windupPercent = 14.801f;
                bWindupTime = 0.656f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = missfortune;
            }
            if (championBox.SelectedIndex == 19)
            {
                windupPercent = 21.484f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = neeko;
            }
            if (championBox.SelectedIndex == 20)
            {
                windupPercent = 17.544f;
                bWindupTime = 0.668f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = quinn;
            }
            if (championBox.SelectedIndex == 21)
            {
                windupPercent = 15.00f;
                bWindupTime = 0.658f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = samira;
            }
            if (championBox.SelectedIndex == 22)
            {
                windupPercent = 18.7f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = soraka;
            }
            if (championBox.SelectedIndex == 23)
            {
                windupPercent = 12.00f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = sivir;
            }
            if (championBox.SelectedIndex == 24)
            {
                windupPercent = 21.574f;
                bWindupTime = 0.69f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = teemo;
            }
            if (championBox.SelectedIndex == 25)
            {
                windupPercent = 14.801f;
                bWindupTime = 0.656f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = tristana;
            }
            if (championBox.SelectedIndex == 27)
            {
                windupPercent = 20.192f;
                bWindupTime = 0.679f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = twitch;
            }
            if (championBox.SelectedIndex == 26)
            {
                windupPercent = 24.404f;
                bWindupTime = 0.651f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = twistedfate;
            }
            if (championBox.SelectedIndex == 28)
            {
                windupPercent = 17.544f;
                bWindupTime = 0.658f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = varus;
            }
            if (championBox.SelectedIndex == 29)
            {
                windupPercent = 17.544f;
                bWindupTime = 0.658f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = vayne;
            }
            if (championBox.SelectedIndex == 30)
            {
                windupPercent = 17.687f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = xayah;
            }
            if (championBox.SelectedIndex == 31)
            {
                windupPercent = 18.000f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = zilean;
            }
            championBox.Focus();
        }

        private void championBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedChampion = championBox.Items[championBox.SelectedIndex].ToString();

            if (selectedChampion == "Aphelios")
            {
                windupPercent = 15.333f;
                bWindupTime = 0.64f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = aphelios;
            }
            if (selectedChampion == "Ashe")
            {
                windupPercent = 21.93f;
                bWindupTime = 0.658f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = ashe;
            }
            if (selectedChampion == "Azir")
            {
                windupPercent = 15.625f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = azir;
            }
            if (selectedChampion == "Bard")
            {
                windupPercent = 18.75f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = bard;
            }
            if (selectedChampion == "Caitlyn")
            {
                windupPercent = 17.708f;
                bWindupTime = 0.681f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = caitlyn;
            }
            if (selectedChampion == "Corki")
            {
                windupPercent = 10.00f;
                bWindupTime = 0.638f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = corki;
            }
            if (selectedChampion == "Draven")
            {
                windupPercent = 15.614f;
                bWindupTime = 0.679f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = draven;
            }
            if (selectedChampion == "Ezreal")
            {
                windupPercent = 18.839f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = ezreal;
            }
            if (selectedChampion == "Gnar")
            {
                windupPercent = 14.6f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = gnar;
            }
            if (selectedChampion == "Jayce") 
            {
                windupPercent = 9.5f;
                bWindupTime = 0.658f;
                windupModifier = 0.005f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = jayce;
            }
            if (selectedChampion == "Jinx")
            {
                windupPercent = 16.875f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = jinx;
            }
            if (selectedChampion == "Kai'Sa")
            {
                windupPercent = 16.108f;
                bWindupTime = 0.644f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kaisa;
            }
            if (selectedChampion == "Kalista") // TODO: "Kalista Double Jump" a weird exploit happens at 4.0+ attack speed. Only happens at (certain ms? ms difference? 32 + 5?)
            {
                windupPercent = 36.000f;
                bWindupTime = 0.694f;
                windupModifier = 0.75f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kalista;
            }
            if (selectedChampion == "Kayle")
            {
                windupPercent = 19.355f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kayle;
            }
            if (selectedChampion == "Kennen")
            {
                windupPercent = 20.00f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kennen;
            }
            if (selectedChampion == "Kindred")
            {
                windupPercent = 17.544f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kindred;
            }
            if (selectedChampion == "Kog'Maw")
            {
                windupPercent = 16.622f;
                bWindupTime = 0.665f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = kogmaw;
            }
            if (selectedChampion == "Lucian")
            {
                windupPercent = 15.00f;
                bWindupTime = 0.638f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = lucian;
            }
            if (selectedChampion == "Miss Fortune")
            {
                windupPercent = 14.801f;
                bWindupTime = 0.656f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = missfortune;
            }
            if (selectedChampion == "Neeko")
            {
                windupPercent = 21.484f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = neeko;
            }
            if (selectedChampion == "Quinn")
            {
                windupPercent = 17.544f;
                bWindupTime = 0.668f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = quinn;
            }
            if (selectedChampion == "Samira")
            {
                windupPercent = 15.00f;
                bWindupTime = 0.658f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = samira;
            }
            if (selectedChampion == "Soraka")
            {
                windupPercent = 18.7f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = soraka;

            }
            if (selectedChampion == "Sivir")
            {
                windupPercent = 12.00f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = sivir;
            }
            if (selectedChampion == "Teemo")
            {
                windupPercent = 21.574f;
                bWindupTime = 0.69f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = teemo;
            }
            if (selectedChampion == "Tristana")
            {
                windupPercent = 14.801f;
                bWindupTime = 0.656f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = tristana;
            }
            if (selectedChampion == "Twitch")
            {
                windupPercent = 20.192f;
                bWindupTime = 0.679f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = twitch;
            }
            if (selectedChampion == "Twisted Fate")
            {
                windupPercent = 24.404f;
                bWindupTime = 0.651f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = twistedfate;
            }
            if (selectedChampion == "Varus")
            {
                windupPercent = 17.544f;
                bWindupTime = 0.658f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = varus;
            }
            if (selectedChampion == "Vayne")
            {
                windupPercent = 17.544f;
                bWindupTime = 0.658f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = vayne;
            }
            if (selectedChampion == "Xayah")
            {
                windupPercent = 17.687f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = xayah;
            }
            if (selectedChampion == "Zilean")
            {
                windupPercent = 18.000f;
                bWindupTime = 0.625f;
                windupModifier = 1f;

                windupPercentLabel.Text = windupPercent.ToString();
                baseWindupTimeLabel.Text = bWindupTime.ToString();
                windupModifierLabel.Text = windupModifier.ToString();
                championPic.ImageLocation = zilean;
            }
        }

        public static float getWindupPercent()
        {
            return windupPercent;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.selectedChamp = championBox.SelectedIndex;
            Properties.Settings.Default.Save();

            CatHackGUI mainForm = new CatHackGUI();
            mainForm.Show();
            this.Hide();
        }
    }
}
