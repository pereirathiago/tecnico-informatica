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
    
             // scale your object first!!!
         texture{ pigment{ brick color White                // color mortar
                                 color rgb<0.8,0.25,0.1>    // color brick
                           brick_size <0.25, 0.0525, 0.125> // format in x ,y and z- direction 
                           mortar 0.01                      // size of the mortar 
                         } // end of pigment
                  normal {wrinkles 0.75 scale 0.01}
                  finish {ambient 0.15 diffuse 0.95 phong 0.2} 
                  scale 3
                  rotate<0,0,0>  translate<0.01, 0.04,-0.10>
               } // end of texture

}   

box {
    <-1,-1,-1>
    <1,1,1>    
    
    scale <14,14,14>    
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
   scale <5,15,1> 
   translate <0,0,-15> 
          texture{ T_Wood15    
                finish { phong 1 } 
                rotate<0,0,0> scale 0.5 translate<0,0,0>
              } // end of texture 

}     

sphere {
    <0,0,0>1.5
      
   translate <2.8,6,-14.8> 
   pigment{
    color Yellow
   }
   
}
        
fog {
    distance 1000
    color White
}                                         

