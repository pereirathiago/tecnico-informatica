#include "colors.inc"

camera {
    location <0,7,-5>
    look_at <0,0,0>
}                  

light_source {
    <0,8,-5>
    color White
}              

cone{
    <0,0,0>,0
    <0,2,1>,0.7
           texture{ pigment{ color rgb<0.9,0.1,0.3>*0.7 }
                normal { pigment_pattern{ gradient <0,1,0> 
                                          sine_wave frequency 1/3 scale 0.08  
                                          color_map {[0, rgb 0.2]
                                                     [1, rgb 0.8]}
                                        }
                          1.5  
                          translate<0,-0.5,0>}
                 finish { phong 1  phong_size 5 reflection{ 0.15 } }
               } // end of texture ------------------------------------------ 


}    

sphere {
    <0,2,1>, 0.65
             texture { pigment{ color rgb< 0.0, 1.0, 0.5> } //  blue green
                // normal { bumps 0.5 scale 0.05 }
                   finish { phong 1 reflection 0.00}
                 } // end of texture 

}  
sphere {
    <0,3,1>,0.55
            texture{ pigment{ color rgb <0.95,0.750,0.05> }
                 normal { wood 2.5 scale 0.15 }
                 finish { phong 1  reflection{ 0.25 } }
               }  // end of texture ---------------------------

}

