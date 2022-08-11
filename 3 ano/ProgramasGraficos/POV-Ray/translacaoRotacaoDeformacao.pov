#include "colors.inc"

camera {
    location <0,5,-5>
    look_at <0,0,0>
}  

light_source {
    <0,8,-5>
    color White
}            

box {
    <-1,-1,-1>
    <1,1,1>
    pigment {color Red}         
    rotate <25,0,0>
    scale <2,2,2>
    translate<-3,2,0>                            
    
}