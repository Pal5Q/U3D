# U3D

U3D TimeScale Sample


暂停和加速播放是游戏常见的操作，在U3D中采用设置Time.timeScale来控制。

   timeScale,含义Unity的游戏时间缩放比例，影响所有和时间有关的功能，不会影响Update和LateUpdate的执行速度。
   
 比如：
 
    Time .timeScale = 2;
    void Update()
    {
        m_transform.position -= new Vector3(6, 0, 0);
    } 
   这个不受影响
   
FixedUpdate是根据时间来的，所以timeScale只会影响FixedUpdate的速度。

    Time.timeScale还会影响Time.time的时间，比如 Time.timeScale ＝ 2的话，那么Time.time的增长速度也会变成2倍速度。
如果在游戏中想不受timeScale的影响，比如在暂停页面播放动画，那就要采用Time.realtimeSinceStartup。

    realtimeSinceStartup，从游戏开始的实时时间，与timeScale无关
注意一下：现在U3D有个bug，使用realtimeSinceStartup必须在Awake()方法以后再取，如果在Awake()方法里面取Time.realtimeSinceStartup会取出一个错误的值， 在Start方法里面取的话就正常了。返回错误的值是你上次关闭游戏的间隔

   解决在暂停下的动画和粒子效果主要思路，利用Time.realtimeSinceStartup产生的差值，来模拟动画.
   
demo中有几个简单的示例，比如Animator和粒子系统(Particle system)
通过修改脚本中的timescalecontrol变量的bool值来控制是否采用TimeScale暂停和加速
