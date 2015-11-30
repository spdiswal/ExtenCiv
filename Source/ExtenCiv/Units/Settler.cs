﻿using ExtenCiv.Players;

namespace ExtenCiv.Units
{
    public sealed class Settler : IUnit
    {
        public Settler(Player owner) { Owner = owner; }

        /// <summary>
        ///     The player that controls this unit.
        /// </summary>
        public Player Owner { get; }

        /// <summary>
        ///     The remaining movement points of this unit for the current round.
        /// </summary>
        public int RemainingMovement { get; set; }

        /// <summary>
        ///     The total movement points of this unit.
        /// </summary>
        public int TotalMovement { get; } = 1;

        /// <summary>
        ///     The defensive strength of this unit.
        /// </summary>
        public int Defence { get; } = 3;

        /// <summary>
        ///     The attacking strength of this unit.
        /// </summary>
        public int Attack { get; } = 0;

        /// <summary>
        ///     The production costs of this unit.
        /// </summary>
        public int ProductionCost { get; } = 30;

        /// <summary>
        ///     Performs the special action of this unit.
        /// </summary>
        public void PerformAction() { }

        public override string ToString() => $"{Owner} Settler";
    }
}
