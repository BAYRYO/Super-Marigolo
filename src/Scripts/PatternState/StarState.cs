namespace SuperMarigolo.Scripts.PatternState;

public class StarState : State
{
    public State doState(Player player)
    {
        player.changeSpeed(1200f);
        player.changeGravity(0f);
        return player.StarState;
    }
}