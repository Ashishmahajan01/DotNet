namespace ICC;

public class Team{

    private List<Player> _players=new List<Player>();

    public Team(){
        this._players.Add(new Player{ Name="Sachin", Score=100000});
        this._players.Add(new Player{ Name="Sourav", Score=60000});
        this._players.Add(new Player{ Name="Rishabh", Score=6000});
        this._players.Add(new Player{ Name="Virat", Score=30000});
        this._players.Add(new Player{ Name="Rahul", Score=80000});
    }

    //Indexer
    public Player this[int index]{
        get{ return this._players[index];}
        set{this._players[index]=value;}
    }


}