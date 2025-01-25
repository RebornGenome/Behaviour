using PatternChainOfResponsibility;
using PatternChainOfResponsibility.Handlers;

class Program
{
    static void Main(string[] args)
    {
        SniperSoldier sniperSoldier = new SniperSoldier();
        Minesweeper minesweeper = new Minesweeper();
        NurseSoldier nurseSoldier = new NurseSoldier();

        sniperSoldier.SetNext(minesweeper).SetNext(nurseSoldier);

        Client.ClientPart(sniperSoldier);
    }
}