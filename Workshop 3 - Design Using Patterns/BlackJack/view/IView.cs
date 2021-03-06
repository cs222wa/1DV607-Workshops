﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    public enum Event
        {
            None,
            Play,
            Hit,
            Stand,
            Quit
        }

    interface IView
    {        
        void DisplayWelcomeMessage();        
        void DisplayCard(model.Card a_card);
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayGameOver(bool a_dealerIsWinner);
        void PauseRedraw();
        Event GetEvent();
    }
}
