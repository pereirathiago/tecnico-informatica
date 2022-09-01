#include "colors.inc"             
#include "woods.inc"   
#include "stones.inc"

camera {
    location <0,20,-100>
    look_at <0,0,0>
}                  

light_source {
    <0,100,-100>
    color White
}              

sky_sphere {
    pigment {
        gradient y
        color_map {
            [0 color LightBlue]
            [0.3 color Blue]    
        }
    }
}                     

plane{
    <0,1,0>,0
    pigment{
        color Green
    }
}         

box {
    <-1,-1,-1>
    <1,1,1>    
    
    scale <19.3,24,15>
    
    texture{ T_Wood14    
                finish { phong 1 } 
                rotate<0,0,0> scale 0.5 translate<0,0,0>
              }
}   

box {
    <-1,-1,-1>
    <1,1,1>    
    
    scale <14,14,15>    
    rotate<0,0,45>
    
    translate <0,24,0>  
    
           texture{ T_Wood14    
                finish { phong 1 } 
                rotate<0,0,0> scale 0.5 translate<0,0,0>
              }


}        

box{
   <-1,-1,-1>
   <1,1,1>   
}
                                                 

