using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

public class Timer_Manager
{
    private Timer[] m_apTimer = new Timer[0];
    

    public void Create_Timer(int ninterval, ElapsedEventHandler pFunction)
    {
        Array.Resize(ref m_apTimer, m_apTimer.Length + 1);
        if (m_apTimer.Length == 0)
        {
            m_apTimer[0] = new Timer();
        }
        else
        {
            m_apTimer[m_apTimer.Length - 1] = new Timer();
        }

        
        // Seting
        m_apTimer[m_apTimer.Length - 1].Interval = ninterval;
        m_apTimer[m_apTimer.Length - 1].Elapsed += pFunction;
    }

    public bool Start(int nTimerNum)
    {
        if(nTimerNum >= 0 && nTimerNum < m_apTimer.Length)
        {
            m_apTimer[nTimerNum].Start();
            return true;
        }
        return false;
    }

    public bool Stop(int nTimerNum)
    {
        if (nTimerNum >= 0 && nTimerNum < m_apTimer.Length)
        {
            m_apTimer[nTimerNum].Stop();
            return true;
        }
        return false;
    }
}

