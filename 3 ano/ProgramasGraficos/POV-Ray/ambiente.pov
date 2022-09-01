#include "colors.inc"
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
            [0 color Red]
            [0.3 color Yellow]    
        }
    }
}                     

plane{
    <0,1,0>,0
    pigment{
        color Green
    }
}               

sphere{
    <0,0,0>,5
    pigment {
        color Red
    }            
    translate<0,5,0>
}                                               

fog {
    distance 500
    color White
}