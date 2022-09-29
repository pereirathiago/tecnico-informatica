#include "colors.inc"    

camera {
    location <
    40,10,-100>
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
difference{   
    // box casa completa
    box{
        <-15,0,-15>
        <15,30,15>
        pigment{color Yellow}  
    }   
    // box tirar dentro
    box{
        <-13,-15.2,-13>
        <13,19,13>
        pigment{color Gray}
    
    }                  
    // box buraco porta
    box{
        <3,0.01,-12.1>
        <10,12,-15.1>
        pigment{color Brown}
    
    } 
    // box buraco janela      
    box{
        <-11,4,-12.1>
        <-2,12,-15.1>
        pigment{color Brown}
    
    }     
    //tirar parte de cima
    box{
        <15,30,17>
        <-0,-0,-17>
        pigment{color Yellow}
        rotate<0,0,-45>
        translate <-25,28,0>
    } 
    //tirar parte de cima 2
    box{
        <15,30,17>
        <-0,-0,-17>
        pigment{color Yellow}
        rotate<0,0,45>       
        translate <15,17.5,0>
    }           
  
}      

//teto 1
box{
    <15,1,17>
    <-15,-1,-17>
    pigment{color Red}
    rotate<0,0,45>
    translate<-10,21.5,1> 

}  
//teto2
box{
    <15,1,17>
    <-15,-1,-17>
    pigment{color Red}
    rotate<0,0,-45>
    translate<10,21.5,1> 

} 
