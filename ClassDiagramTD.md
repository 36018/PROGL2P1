~~~mermaid



classDiagram

Bullet <|-- Aim
Enemy --|> Endpup
Endpup --|> Mainmenu
Enemy --|> Mainmenu



Class Waypoints
    Waypoints: -waypoints Transform
    Waypoints: -targetposition Vector3
    Waypoints: -waypointIndex int
    Waypoints: -enemy Gameobject
    Waypoints: -speed float
    Waypoints: -start()
    Waypoints: -update()



Class Mainmenu
    Mainmenu: +PlayGame()
    Mainmenu: +QuitGame()
    Mainmenu: +TryAgain()




Class Draggablepoint
    Draggablepoint: -isDrag bool
    Draggablepoint: -Update()
    Draggablepoint: -OnMouseDown()
    Draggablepoint: -OnMouseUp()




Class Aim
    Aim: -bullet Bullet  
    Aim: -ouseposition Vector3   
    Aim: -angle float
    Aim: -start()
    Aim: -update()


Class Bullet
    Bullet: -angle float
    Bullet: -velocity Vector3
    Bullet: -direction Vector3
    Bullet: -speed float
    Bullet: -damage float
    Bullet: -start()
    Bullet: -Update()


Class Endpup
    Endpup: -maxHealth float
    Endpup: -currentHealth float
    Endpup: -healthslider Slider
    Endpup: -endpup GameObject
    Endpup: -start()
    Endpup: -OnTriggerEnter2D(Collider other)
    Endpup: +TakeDamage(float damage)
    Endpup: -Die()


Class Enemy
Enemy: -maxHealth float
Enemy: #currentHealth float
Enemy: -healthslider Slider
Enemy: -Player GameObject
Enemy: -EnemyDamage float
Enemy: #start()
Enemy: -update()
Enemy: -OnTriggerEnter2D(Collider other)
Enemy: +TakeDamage(float damage)
Enemy: -Die()


~~~