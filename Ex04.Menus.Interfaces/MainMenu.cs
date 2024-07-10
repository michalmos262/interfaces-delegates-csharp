using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly MenuItem r_MainItem;
        private MenuItem m_CurrentItem;
        private const string k_GoBackMessage = "Back";
        private const string k_ExitMessage = "Exit";

        public MainMenu(string i_MenuTitle)
        {
            r_MainItem = new MenuItem(i_MenuTitle);
            m_CurrentItem = r_MainItem;
        }

        public MenuItem AddSubItem(string i_SubItemTitle)
        {
           return r_MainItem.AddSubItem(i_SubItemTitle);
        }

        private void verifyUserInput(string i_UserInput, out int o_UserMenuOptionChoice)
        {
            bool isValidInput = int.TryParse(i_UserInput, out o_UserMenuOptionChoice);

            if (!isValidInput)
            {
                throw new FormatException("Invalid input! Menu option should be a number");
            }
            if (!(o_UserMenuOptionChoice >= 1 && o_UserMenuOptionChoice <= r_MainItem.SubItemsCount)
                       && i_UserInput != r_MainItem.ExitButton.ToString())
            {
                throw new ArgumentException(string.Format("Invalid menu option! Option should be a number" +
                                                   
                                                          " between 1 to {0} or {1}", r_MainItem.SubItemsCount,
                    r_MainItem.ExitButton));
            }
        }

        private int getMenuOptionFromUser()
        {
            bool isValidInput = false;
            int userMenuOptionChoice = 0;

            while (!isValidInput)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    verifyUserInput(userInput, out userMenuOptionChoice);
                    isValidInput = true;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            return userMenuOptionChoice;
        }

        public void Show()
        {
            bool isExit = false;

            while (!isExit)
            {
                string exitMessage = (m_CurrentItem.Parent == null ? k_ExitMessage : k_GoBackMessage);
                m_CurrentItem.Show(exitMessage);
                int userChoice = getMenuOptionFromUser();

                if (userChoice.ToString() == m_CurrentItem.ExitButton.ToString())
                {
                    isExit = m_CurrentItem.Parent == null;
                    if (!isExit)
                    {
                        m_CurrentItem = m_CurrentItem.Parent;
                    }
                }
                else
                {
                    m_CurrentItem = m_CurrentItem.GetSubItemByIndex(userChoice - 1);
                    if (m_CurrentItem.SubItemsCount == 0)
                    {
                        m_CurrentItem.SelectItemAndNotifyListeners();
                        m_CurrentItem = m_CurrentItem.Parent;
                    }
                }
            }
        }
    }
}