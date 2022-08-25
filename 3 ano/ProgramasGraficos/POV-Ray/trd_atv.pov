#include "colors.inc"      
#include "woods.inc"

camera {
    location <0,5,-15>
    look_at <0,0,0>
}  

box{
    <-1,0,0>
    <-5,0.5,5>    
    
    scale <4,1,4>   
    translate<13,-2,0>   
         
       texture{ T_Wood14    
                finish { phong 1 } 
                rotate<0,0,0> scale 0.5 translate<0,0,0>
              } // end of texture 

}
            
            
box {
    <-1,-1,-1>
    <1,1,1>
    
    scale <1, 6, 1>   
    
    translate<-4,-8,13>   
       
    texture{ T_Wood14    
                finish { phong 1 } 
                rotate<0,0,0> scale 0.5 translate<0,0,0>
              }
}  

box {
    <-1,-1,-1>
    <1,1,1>
    
    scale <1, 6, 1>   
    
    translate<6,-8,13>   
       
    texture{ T_Wood14    
                finish { phong 1 } 
                rotate<0,0,0> scale 0.5 translate<0,0,0>
              }
}  

box {
    <-1,-1,-1>
    <1,1,1>
    
    scale <1, 6, 1>   
    
    translate<6,-8,3>   
       
    texture{ T_Wood14    
                finish { phong 1 } 
                rotate<0,0,0> scale 0.5 translate<0,0,0>
              }
}    

box {
    <-1,-1,-1>
    <1,1,1>
    
    scale <1, 6, 1>   
    
    translate<-4,-8,3>   
       
    texture{ T_Wood14    
                finish { phong 1 } 
                rotate<0,0,0> scale 0.5 translate<0,0,0>
              }
}    

box {
    <-1,-1,-1>
    <1,1,1>
    
    scale <2, 0.1, 3>          
    rotate <0,10,0>
    
    pigment {
        color White
    }
}