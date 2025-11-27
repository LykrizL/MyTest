using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WorkLibrary;

namespace TravelAgency
{
    public partial class Instructor : Form
    {
        private bool LogFlag;//проверка авторизации
        private List<Users> LoginUser;//список с вошедшим пользователем
        private List<Tours> dataTours;//список туров
        private List<Route> dataRoute;//список маршрутов
        private List<GuestHouse> dataHouse;//список гостевых домов
        private List<Instructors> dataInstructors;//список инструкторов
        public Instructor(List<Users> userLogin, List<Tours> tourData, List<Route> routeData, List<Instructors> instrData, List<GuestHouse> houseData, bool flag)
        {
            InitializeComponent();
            LogFlag = flag;
            LoginUser = userLogin;
            dataTours = tourData;
            dataRoute = routeData;
            dataHouse = houseData;
            dataInstructors = instrData;
        }

        private void Bt_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm(LoginUser, LogFlag);
            form.ShowDialog();
        }
        private void Bt_Tours_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tour tour = new Tour(LoginUser, dataTours, dataRoute, dataInstructors, dataHouse, LogFlag);
            tour.ShowDialog();
        }

        private void Bt_Route_Click(object sender, EventArgs e)
        {
            this.Hide();
            Routes route = new Routes(LoginUser, dataTours, dataRoute, dataInstructors, dataHouse, LogFlag);
            route.ShowDialog();
        }

        private void Bt_Houses_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestHouses house = new GuestHouses(LoginUser, dataTours, dataRoute, dataInstructors, dataHouse, LogFlag);
            house.ShowDialog();
        }

        private void Bt_Profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile(LoginUser, dataTours, dataRoute, dataInstructors, dataHouse, LogFlag);
            profile.ShowDialog();
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            if(LogFlag)
            {
                this.Width = 930;
                this.Height = 629;
                panel1.Width = 930;
                panel1.Height = 550;
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lbInstrFIO1.Text = dataInstructors[0].FullName;
            lbExpInstr1.Text += dataInstructors[0].Experience;
            lbInstrAge1.Text += dataInstructors[0].Age;
            lbInstrQual1.Text += dataInstructors[0].Qualification;
            lbInstrEmail1.Text += dataInstructors[0].Email;

            lbInstrFIO2.Text = dataInstructors[1].FullName;
            lbExpInstr2.Text += dataInstructors[1].Experience;
            lbInstrAge2.Text += dataInstructors[1].Age;
            lbInstrQual2.Text += dataInstructors[1].Qualification;
            lbInstrEmail2.Text += dataInstructors[1].Email;

            lbInstrFIO3.Text = dataInstructors[2].FullName;
            lbExpInstr3.Text += dataInstructors[2].Experience;
            lbInstrAge3.Text += dataInstructors[2].Age;
            lbInstrQual3.Text += dataInstructors[2].Qualification;
            lbInstrEmail3.Text += dataInstructors[2].Email;

            lbInstrFIO4.Text = dataInstructors[3].FullName;
            lbExpInstr4.Text += dataInstructors[3].Experience;
            lbInstrAge4.Text += dataInstructors[3].Age;
            lbInstrQual4.Text += dataInstructors[3].Qualification;
            lbInstrEmail4.Text += dataInstructors[3].Email;

            lbInstrFIO5.Text = dataInstructors[4].FullName;
            lbExpInstr5.Text += dataInstructors[4].Experience;
            lbInstrAge5.Text += dataInstructors[4].Age;
            lbInstrQual5.Text += dataInstructors[4].Qualification;
            lbInstrEmail5.Text += dataInstructors[4].Email;
        }

        private void Instructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            File.Delete("user_Login.txt");
        }
    }
}
