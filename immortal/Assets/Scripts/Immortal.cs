using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immortal : Singleton<Immortal>
{
    private float m_energy = 0;
    private float m_health = 0.8f;
    private float m_mood = 0.8f;

    //private List<>丹药
    private float m_cultivatingAppend = 1;
    private float m_aptitude = 1;//改为灵根类型

    private bool m_cultivatingImmortality = false;

    void Start()
    {
        StartCultivateImmortality();
    }

    public bool StartCultivateImmortality()
    {
        m_cultivatingImmortality = true;
        return true;
    }
    public bool StopCultivateImmortality()
    {
        m_cultivatingImmortality = false;
        return true;
    }
    private void CultivatingImmortality()
    {
        //瓶颈判断

        //环境加成*健康加成*心境加成*丹药加成*物品加成*功法加成*额外加成 * 个人基本单位（灵根）
        m_energy += 1 * m_health * m_mood * 1 * 1 * 1 * m_cultivatingAppend * m_aptitude * Time.fixedDeltaTime;
    }

    private void FixedUpdate()
    {
        if (m_cultivatingImmortality)
        {
            CultivatingImmortality();
        }
        Debug.Log(m_energy);
    }
}
