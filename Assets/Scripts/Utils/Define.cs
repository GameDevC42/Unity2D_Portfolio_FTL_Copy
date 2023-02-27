﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum CreatureState
    {
        Idle,
        Moving,
        Skill,
        Dead,
    }

    public enum EventFlag
    { 
        NonCombat,
        Combat,
    }


public enum CursorState
    {
        Idle,
        TargetMode,
    }

    public enum WeaponState
    {
        Idle,
        Fire,
        Reload,
    }

    public enum MoveDir
    {
        None,
        Up,
        Down,
        Left,
        Right,
    }

    public enum Layer
    {
        UI = 7,
        Monster = 8,
        Ground = 9,
        Block = 10
    }

    public enum Scene
    {
        Unknown,
        Login,
        Lobby,
        Game,
    }

    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount,
    }

    public enum UIEvent
    {
        Click,
        Drag,
        PointerEnter,
        PointerExit
    }

    public enum MouseEvent
    {
        Press,
        PointerDown,
        PointerUp,
        Click
    }
}
