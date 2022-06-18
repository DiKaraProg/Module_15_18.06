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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Library_Module_13_OOP;

namespace MOdule13_OOP
{
    /// <summary>
    /// Логика взаимодействия для TransferMoney.xaml
    /// </summary>
    public partial class TransferMoney : Window
    {
        EventLog eventLog = new EventLog();
        public event Action<string> Warning;
        public TransferMoney()
        {
            InitializeComponent();
            Warning += Bank_A.Clue_Popup;
            
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            bool senderFlag= false;
            bool resipientFlag= false;
            foreach (var item in Bank_A.AllClientsInfo)
            {
                if (item.Id == Convert.ToInt32(RecipientUserId.Text))
                {
                    foreach (var item1 in item.Listaccount)
                    {
                        if (item1.AccountId == Convert.ToInt32(RecipientAccountId.Text))
                        {
                            item1.Sum += Convert.ToInt32(Sum.Text);
                            senderFlag = true; break;
                        }
                    }
                    break;
                }
            }
            foreach (var item in Bank_A.AllClientsInfo)
            {
                if (item.Id == Convert.ToInt32(SenderUserId.Text))
                {
                    foreach (var item1 in item.Listaccount)
                    {
                        if (item1.AccountId == Convert.ToInt32(SenderAccountId.Text))
                        {
                            item1.Sum -= Convert.ToInt32(Sum.Text);
                            resipientFlag = true; break;
                        }
                    }
                    break;
                }


            }
            if (senderFlag && resipientFlag)
            {


                foreach (var item in Bank_A.AllClientsInfo)
                {
                    if (item.Id == Convert.ToInt32(SenderUserId.Text))
                    {
                        foreach (var item1 in item.Listaccount)
                        {
                            if (item1.AccountId == Convert.ToInt32(SenderAccountId.Text))
                            {
                                if (item1.Sum- Convert.ToDouble(Sum.Text)>=0)
                                {
                                    item1.Sum -= Convert.ToDouble(Sum.Text); break;
                                }
                                else
                                {
                                    Warning?.Invoke("Сумма перевода  больше чем средств на счету");break;
                                }
                               
                            }

                        }
                        break;
                    }


                }
                foreach (var item in Bank_A.AllClientsInfo)
                {
                    if (item.Id == Convert.ToInt32(RecipientUserId.Text))
                    {
                        foreach (var item1 in item.Listaccount)
                        {
                            if (item1.AccountId == Convert.ToInt32(RecipientAccountId.Text))
                            {
                                item1.Sum += Convert.ToInt32(Sum.Text); break;

                            }

                            break;
                        }

                    }

                }
            }
            else
            {
                Warning.Invoke("Значения введены не верно");
            }

            JsonSerializationAndDeserialization.SerialiseAllClientInfo("Data.json");
            eventLog.AddToEventLog(new EventLog(MainWindow.UserChoiseFlag, $"Перевод средств - Клиент с Id: {SenderUserId.Text} перевел со счетa: {SenderAccountId.Text} -" +
                $" Сумму: {Sum.Text}$  клиенту с Id: {RecipientUserId.Text} на номер счета: {RecipientAccountId.Text}"), "Перевод состаялся удачно");
        }
    }
}
