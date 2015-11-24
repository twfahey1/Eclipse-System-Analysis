using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclipse_System_Analysis
{
    public partial class Form1 : Form
    {
        EclipseInfoGenerator eclipseInfoGen = new EclipseInfoGenerator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Call our object to initialize the user ini list, and the backup folder items...
            startupProcedure();
        }

        private void startupProcedure()
        {
            mainDir5Label.Text = eclipseInfoGen.CURRENT_MAINDIRECTORY5;
            eclipseInfoGen.BUILD_INI_LIST_FROM_PATH(eclipseInfoGen.CURRENT_MAINDIRECTORY5);
            foreach(EclipseObject user in eclipseInfoGen.CURRENT_LOADED_INI_ECL_OBJS)
            {
                userListBox.Items.Add(user.FILE_NAME);
            }
            if (eclipseInfoGen.ValidateBackupsFolder(eclipseInfoGen.CURRENT_LOADED_INI_ECL_OBJS))
            {
                foreach(string recovUserPath in eclipseInfoGen.RECOV_USERS_LOADED.Keys)
                {
                    backupFolderList.Items.Add(recovUserPath);
                }
            }
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //First clear job files list
            jobFilesList.Items.Clear();
            //This call will build job info list from the selected ini file, and then we can access that data and display it
            //in the jobFiles list...
            eclipseInfoGen.BUILD_JOB_INFO_LIST(eclipseInfoGen.CURRENT_LOADED_INI_ECL_OBJS[userListBox.SelectedIndex].INI_JOB_PATH);
            foreach (string filePath in eclipseInfoGen.JOB_INFO_LIST)
            {
                jobFilesList.Items.Add(filePath);
            }
        }
    }
}
