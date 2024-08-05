namespace ApiPedidos.Contratos
{
    
    public interface IBus
    {
        public void Publish<T>(T message);
    }
}