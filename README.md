# Metaverse

프로젝트 개요
프로젝트명 : TextRPG Fantasy
개발 환경 : Unity
플레이 방법
마을에서 이동을하며 npc나 포탈을통해 미니게임을 해볼수있다 .
----------------------------------------------------------


와이어프레임


![Image](https://github.com/user-attachments/assets/fb273b69-4ff0-494a-8cc1-73de6df0d2d5)



----------------------------------------------------------
구현기능 

wasd , 방향키로 이동이가능하고 점프가가능 
(Ground) 위에서만 움직일수있고 공중이면 밑으로 떨어진다 .
상호작용을통해 다른 미니게임으로 전환이 가능하다 


----------
발생한 문재점 ,해결

씬이 한번만작동하고 다시하기나 ,마을로 돌아갔을경우 멈추게되었다.
Time.timeScale =1 ;  타임스케일을 씬시작시에 1로 넣어 해결되었다 .

플레이어가 collider 충돌도 무시하고 멈추지않고 튕겨져나가는 현상이 발생했다 .

![Image](https://github.com/user-attachments/assets/689a66fb-2a90-4a95-8c94-d8bcac309fa9)


이렇게 메인카메라 안에 플레이어가 들어가서 발생하는 현상이였다 .
플레이어를 밖으로 빼주니 바로 수정되었다 .

간혹 플레이어가 끼어서 안움직이는 경우가있는데 아직 수정하지못하였다 .
