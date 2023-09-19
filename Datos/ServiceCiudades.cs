using PracticaInyeccionDependencias.Datos.Interfaces;

namespace PracticaInyeccionDependencias.Datos
{
    public class ServiceCiudades : IServiceCiudades
    {
        private List<string> _ciudades;

        private Guid idServicio;

        public Guid IdServicio
        {
            get { return idServicio; }
        }

        public ServiceCiudades()
        {
            idServicio = Guid.NewGuid();

            _ciudades = new List<string>
            {
                "Bogotá",
                "Lima",
                "New York",
                "Tokyo",
                "Buenos Aires",
                "Roma",
                "Miami"
            };
        }

        public List<string> GetCiudades()
        {
            return _ciudades;
        }
    }
}
