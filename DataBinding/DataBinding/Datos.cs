

namespace DataBinding
{
    using System.Collections.ObjectModel;
    public class Datos:Notificable
    {
        private ObservableCollection<Persona> personas;
        public ObservableCollection<Persona> Personas
        {
            get
            {
                return personas;
            }
            set
            {
                if(personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChanged();
            }
        }
    }
}
