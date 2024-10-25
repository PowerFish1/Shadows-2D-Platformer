using System;
using UnityEngine;

namespace Powerfish.Utilities
{
    public class Timer
    {
        public event Action OnTimerDone;

        private float startTime;
        private float duration;
        private float targetTime;

        private bool isActive;

        public Timer(float duration)
        {
            this.duration = duration;
        }
                
        public void StartTimer()
        {
            startTime = Time.time;
            targetTime = startTime + duration;
            Debug.Log("target time = " + targetTime);
            Debug.Log("start time = " + startTime);
            isActive = true;
        }

        public void StopTimer()
        {
            Debug.Log(" time = " + Time.time);
            isActive = false;
        }

        public void Tick()
        {

            if (!isActive) return;


            if (Time.time >= targetTime)
            {
                OnTimerDone?.Invoke();
                StopTimer();
            }
        }
    }
}
