#include "colors.inc"

camera {
    location <0,5,-5>
    look_at <0,0,0>
}           

light_source {
    <0,8,-5>
    color White
}

sphere {
    <0,0,0>, 1
              texture{ pigment{ color rgb< 1, 1, 1>*0.75 } //  color Gray75
                // normal { bumps 0.5 scale 0.05 }
                   finish { phong 1 }
                 } // end of texture 

}          
      

box {
    <-1,0,0>
    <-2,1,1>      
           texture{ pigment{ color rgb<0.55,0.35,0.75> }
                normal { pigment_pattern{ 
                             brick color rgb 0.2, color rgb 0.8 
                             scale 0.065  turbulence 0.14
                           } // end pigment_pattern
                         1} // end normal
                finish { phong 0.1  phong_size 500 reflection{ 0.45 } }
              }  


}    
cylinder {
    <2,0,0>
    <2,1,0>, 1
    pigment {
        color Green
    }
}                            
cone{
    <2,1,0>,0.9
    <2,2,0>,0
    pigment {
        color Yellow
    }
}  

torus {
    3, 0.1
    pigment {
        color Pink
    }
}