using System.ComponentModel;

namespace WinProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void BindDataFirmwareGrid()
        {
            try
            {

                ProgressBarColumn progressBarColumn = new ProgressBarColumn();
                softwareupdatedataGrid.ColumnCount = 3;

                softwareupdatedataGrid.Columns[0].Name = "Software";
                softwareupdatedataGrid.Columns[0].HeaderText = "Software Name";
                softwareupdatedataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                softwareupdatedataGrid.Columns[1].Name = "SwVersion";
                softwareupdatedataGrid.Columns[1].HeaderText = "Sw Version";
                softwareupdatedataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                softwareupdatedataGrid.Columns[2].Name = "NewestVersion";
                softwareupdatedataGrid.Columns[2].HeaderText = "Newest Version";
                softwareupdatedataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



                softwareupdatedataGrid.Columns.Add(progressBarColumn);
                softwareupdatedataGrid.Columns[3].Name = "Progress";
                softwareupdatedataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                progressBarColumn.HeaderText = "Progress";

                object[] softwareRow1 = new object[]
                        {
                            "Security App",
                            "1.2",
                            "1.3",
                            80
                        };
                object[] softwareRow2 = new object[]
                       {
                            "Spam Remover",
                            "5.0",
                            "5.0.1",
                            40
                       };
                object[] softwareRow3 = new object[]
                       {
                            "Chat App",
                            "4.0.0",
                            "4.0.1",
                            30
                       };
                softwareupdatedataGrid.Rows.Add(softwareRow1);
                softwareupdatedataGrid.Rows.Add(softwareRow2);
                softwareupdatedataGrid.Rows.Add(softwareRow3);
            }
            catch (Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDataFirmwareGrid();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < softwareupdatedataGrid.Rows.Count; i++)
            {
                if(softwareupdatedataGrid.Rows[i].Cells["Progress"].Value!=null)
                {
                    int currentState = (int)softwareupdatedataGrid.Rows[i].Cells["Progress"].Value;
                    if (currentState < 100)
                    {
                        softwareupdatedataGrid.Rows[i].Cells["Progress"].Value = currentState + 1; ;
                    }
                }
            }
        }
    }
}