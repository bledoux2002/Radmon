using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature
{
    public CreatureBase Base { get; set; }

    public int Level { get; set; }

    public int HP { get; set; }

    public List<Move> Moves { get; set; }

    public Creature(CreatureBase cBase, int cLevel)
    {
        Base = cBase;
        Level = cLevel;
        HP = MaxHp;

        // Generate Moves
        Moves = new List<Move>();
        foreach (var move in Base.LearnableMoves)
        {
            if (move.Level <= Level)
                Moves.Add(new Move(move.Base));
            if (Moves.Count >= 4)
                break;
        }
    }

    public int MaxHp { 
        get { return Mathf.FloorToInt((Base.MaxHp * Level) / 100f) + 5; }
    }

    public int Attack { 
        get { return Mathf.FloorToInt((Base.Attack * Level) / 100f) + 5; }
    }

    public int Defense { 
        get { return Mathf.FloorToInt((Base.Defense * Level) / 100f) + 5; }
    }

    public int SpAttack { 
        get { return Mathf.FloorToInt((Base.SpAttack * Level) / 100f) + 5; }
    }

    public int SpDefense { 
        get { return Mathf.FloorToInt((Base.SpDefense * Level) / 100f) + 5; }
    }

    public int Speed { 
        get { return Mathf.FloorToInt((Base.Speed * Level) / 100f) + 10; }
    }
}
