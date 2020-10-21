using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskmgr
{
    public partial class FormMain : Form
    {
        const int allMemory = 1024;
        int indexForStop = 77777;
        Boolean checkSelectItem = true;
        int speedProcessor = 100;    //Количество тактов в секунду
        int time = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        //Загрузка основной формы
        private void Form1_Load(object sender, EventArgs e)
        {
            statusMemory();
            listBoxPID.BackColor = Color.Khaki;
            listBoxName.BackColor = Color.Khaki;
            listBoxStatus.BackColor = Color.Khaki;
            listBoxPriority.BackColor = Color.Khaki;
            listBoxMemory.BackColor = Color.Khaki;
            textBoxSpeed.Text = speedProcessor.ToString();
            timer1.Enabled = true;
            timer1.Start();
        }

        //Расчет доступной памяти
        public void statusMemory()
        {
            int currentMemory = 0;

            for (int i = 0; i < listBoxMemory.Items.Count; i++)
            {
                if(listBoxStatus.Items[i].ToString() == "Active")
                {
                    currentMemory += Convert.ToInt32(listBoxMemory.Items[i]);
                }
            }
            if(currentMemory > allMemory)
            {
                MessageBox.Show("Кончилась память");
            }
            textBoxAboutMemory.Text = currentMemory + " / " + allMemory;

        }

        //Добавление нового процесса
        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            Process process = new Process();

            string newName;
            int newPID;
            int newMemory;

            FormAddNewProcess addForm = new FormAddNewProcess();

            if(addForm.ShowDialog() == DialogResult.OK)
            {
                newName = addForm.getNewName();
                newPID = addForm.getNewPID();
                newMemory = addForm.getNewMemory();
                process.set(newPID, newName, newMemory);

                listBoxPID.Items.Add(newPID);
                listBoxName.Items.Add(newName);
                listBoxStatus.Items.Add("Active");
                //priority
                listBoxMemory.Items.Add(newMemory);

                statusMemory();
            }
                    
            
        }

        //Удаление процесса
        private void buttonRemoveProcess_Click(object sender, EventArgs e)
        {
            /*  Удаление по введенному PID
            FormRemoveProcess removeForm = new FormRemoveProcess();
            int PID;

            if(removeForm.ShowDialog() == DialogResult.OK)
            {
                PID = removeForm.getRemovingPID();
                int index;

                if(listBoxPID.Items.Contains(PID) == true)
                {
                    index = listBoxPID.Items.IndexOf(PID);
                    //listBoxPID.Items.Remove(index);
                    listBoxPID.Items.RemoveAt(index);
                    listBoxName.Items.RemoveAt(index);
                    //status
                    //priority
                    listBoxMemory.Items.RemoveAt(index);
                }
                statusMemory();
            }
            */
            if(indexForStop != 77777)
            {
                checkSelectItem = false;

                clearSelectedListBox();
                listBoxPID.Items.RemoveAt(indexForStop);
                listBoxName.Items.RemoveAt(indexForStop);
                listBoxStatus.Items.RemoveAt(indexForStop);
                //listBoxPriority.Items.RemoveAt(indexForStop);
                listBoxMemory.Items.RemoveAt(indexForStop);

                indexForStop = 77777;
                checkSelectItem = true;
                statusMemory();
            }
            else
            {
                MessageBox.Show("Select a process!", "Error");
            }
        }

        //Очистка выделений ListBox
        public void clearSelectedListBox()
        {
            listBoxPID.SetSelected(indexForStop, false);
            listBoxName.SetSelected(indexForStop, false);
            listBoxStatus.SetSelected(indexForStop, false);
            //listBoxPriority.SetSelected(indexForStop, false);
            listBoxMemory.SetSelected(indexForStop, false);

        }

        //Остановка/Восстановление работы процесса
        private void buttonPauseRestore_Click(object sender, EventArgs e)
        {
            if(indexForStop != 77777)
            {
                if(listBoxStatus.Items[indexForStop].ToString() == "Active")
                {
                    listBoxStatus.Items[indexForStop] = "Stoped";
                }
                else
                {
                    listBoxStatus.Items[indexForStop] = "Active";
                }
                statusMemory();
            }
            else
            {
                MessageBox.Show("Select a process!", "Error");
            }
        }

        //Выделение в других колонках
        private void listBoxPID_SelectedIndexChanged(object sender, EventArgs e)
        {
                if(checkSelectItem == true)
            {
                indexForStop = listBoxPID.SelectedIndex;
                listBoxName.SetSelected(indexForStop, true);
                listBoxStatus.SetSelected(indexForStop, true);
                //listBoxPriority.SetSelected(indexForStop, true);
                listBoxMemory.SetSelected(indexForStop, true);
            }
                
        }

        //Повышение скорости
        private void buttonIncreaseSpeed_Click(object sender, EventArgs e)
        {
            if(speedProcessor != 1000)
            {
                speedProcessor += 100;
            }
            else
            {
                MessageBox.Show("Максимальная скорость процессора!");
            }

            textBoxSpeed.Text = speedProcessor.ToString();
        }

        //Понижение скорости
        private void buttonReduceSpeed_Click(object sender, EventArgs e)
        {
            if(speedProcessor != 0)
            {
                speedProcessor -= 100;
            }
            else
            {
                MessageBox.Show("Все процессы остановлены!");
            }
            textBoxSpeed.Text = speedProcessor.ToString();
        }

        //Таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time % 10 == 0)
            {
                textBoxTimer.Text = (time / 10).ToString();
            }
            time++;
        }
    }
}
