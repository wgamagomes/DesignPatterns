namespace Xpto.Behavioral.Mediator
{
    /// <summary>
    /// The Mediator pattern is there to enable objects to 
    /// communicate without knowing each other’s identities.
    /// It also encapsulates a protocol that objects can follow.
    /// </summary>
    public class Mediator
    {
        public delegate void Callback(string message, string from);

       private  Callback _respond;

        public void SignOn(Callback method)
        {
            _respond += method;
        }
        public void Block(Callback method)
        {
            _respond -= method;
        }
        public void Unblock(Callback method)
        {
            _respond += method;
        }
        // Send is implemented as a broadcast 30         public void Send(string message, string from) { 31           respond(message, from); 32           Console.WriteLine(); 33         } 
    }
}
