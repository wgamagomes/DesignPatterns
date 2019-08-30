namespace Xpto.Behavioral.Mediator
{
    public class Mediator
    {
        public delegate void Callback(string message, string from);
        Callback respond;
        public void SignOn(Callback method)
        {
            respond += method;
        }
        public void Block(Callback method)
        {
            respond -= method;
        }
        public void Unblock(Callback method)
        {
            respond += method;
        }
        // Send is implemented as a broadcast 30         public void Send(string message, string from) { 31           respond(message, from); 32           Console.WriteLine(); 33         } 
    }
}
