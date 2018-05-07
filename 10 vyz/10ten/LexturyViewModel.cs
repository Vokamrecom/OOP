using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using SampleMVVM.Commands;

namespace _10ten
{
    class LexturyViewModel : INotifyPropertyChanged
    {
        public Lextury lextury;
        TicketsContext db;


        public LexturyViewModel(Lextury ticket)
        {
            this.lextury = ticket;
        }

        public int Id
        {
            get
            {
                return lextury.Id;
            }
            set
            {
                lextury.Id = value;
                //OnPropertyChanged("Id");
            }
        }

        public string Title
        {
            get
            {
                return lextury.Title;
            }
            set
            {
                lextury.Title = value;
                //OnPropertyChanged("Title");
            }
        }

        public string Date
        {
            get
            {
                return lextury.Date;
            }
            set
            {
                lextury.Date = value;
                //OnPropertyChanged("Date");
            }
        }

        public string Type
        {
            get
            {
                return lextury.NameLector;
            }
            set
            {
                lextury.NameLector = value;
                //OnPropertyChanged("Type");
            }
        }

        public int Count
        {
            get
            {
                return lextury.Count;
            }
            set
            {
                lextury.Count = value;
                OnPropertyChanged("Count");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #region Commands

        #region Купить

        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(GetItem);
                }
                return getItemCommand;
            }
        }

        private void GetItem()
        {
            Count++;
            db = new TicketsContext();
            db.Lexturys.Load();
            Lextury ticket = new Lextury();
            ticket = db.Lexturys.Find(Id);
            ticket.Count = Count;
            db.SaveChanges();
            db.Dispose();
        }

        #endregion

        #region Возврат

        private DelegateCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new DelegateCommand(GiveItem, CanGiveItem);
                }
                return giveItemCommand;
            }
        }

        private void GiveItem()
        {
            Count--;
            db = new TicketsContext();
            db.Lexturys.Load();
            Lextury ticket = new Lextury();
            ticket = db.Lexturys.Find(Id);
            ticket.Count = Count;
            db.SaveChanges();
            db.Dispose();
        }

        private bool CanGiveItem()
        {
            return Count > 0;
        }

        #endregion

        #region Добавление книги
        private DelegateCommand addItemCommand;

        public ICommand AddItemCommand
        {
            get
            {
                if (addItemCommand == null)
                {
                    addItemCommand = new DelegateCommand(AddItem);
                }
                return addItemCommand;
            }
        }

        private void AddItem()
        {
            db = new TicketsContext();
            db.Lexturys.Load();
            Random rand = new Random();
            Lextury ticket = new Lextury();
            ticket.Title = Title;
            ticket.Count = rand.Next(1, 100);
            ticket.Date = Date;
            ticket.NameLector = Type;

            db.Lexturys.Add(ticket);
            
            db.SaveChanges();
            db.Dispose(); 
            MessageBox.Show("Добавили " + ticket.Title);
        }
        #endregion
        #endregion
    }
}
