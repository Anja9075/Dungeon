namespace Dungeon;

public class IMoveable
{
    public enum ERichtungen
    {
        ENone,
        EVorne,
        EZurück,
        ERechts,
        ELinks
    }

    public interface IMove
    { 
        public void Move(ERichtungen richtungen);
    }
    
}