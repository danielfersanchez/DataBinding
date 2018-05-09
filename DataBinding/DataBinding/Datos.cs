

namespace DataBinding
{
    using System.Collections.ObjectModel;
    public class Datos:Notificable
    {
        private ObservableCollection<Persona> personas;
        private Persona personaSeleccionada;

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

        public Persona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                if(personaSeleccionada == value)
                {
                    return;
                }
                personaSeleccionada = value;
                OnPropertyChanged();
            }
        }

        #region Constructores
        public Datos()
        {
            Personas = new ObservableCollection<Persona>();
            for (int i = 0; i < 5; i++)
            {
                Personas.Add(new Persona()
                {
                    Nombre = $"Persona {i}",
                    Pais = $"Pais {i}"
                });
            }
        }
        #endregion
    }
}
