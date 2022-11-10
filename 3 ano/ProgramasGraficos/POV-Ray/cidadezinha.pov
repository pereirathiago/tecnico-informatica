#include "colors.inc"               
#include "Car_01.inc"

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

#include "objs/Street_00.inc"   
#include "objs/Truck_11.inc"    

camera {
    location <40,10,-100>
    look_at <0,0,0>
}                  

// sun ---------------------------------------------------------------------
light_source{< 2500,2500,-2500> color White}

// sky -------------------------------------------------------------- 
plane{<0,1,0>,1 hollow  
       texture{ pigment{ bozo turbulence 0.92
                         color_map { [0.00 rgb <0.20, 0.20, 1.0>*0.9]
                                     [0.50 rgb <0.20, 0.20, 1.0>*0.9]
                                     [0.70 rgb <1,1,1>]
                                     [0.85 rgb <0.25,0.25,0.25>]
                                     [1.0 rgb <0.5,0.5,0.5>]}
                        scale<1,1,2.5>*2.5  translate< 0,0,5>
                       }
                finish {ambient 1 diffuse 0} }      
       scale 10000}


// ground ------------------------------------------------------------
plane { <0,1,0>, 0 
        texture{ pigment{ color rgb<0.35,0.65,0.0>*0.72 }
	         normal { bumps 0.75 scale 0.015 }
                 finish { phong 0.1 }
               } // end of texture
      } // end of plane
//--------------------------------------------------------------------------

   
object{ Street_00( 6,     // Street_Widthm, // 
               1000 , // Street_Length, //
               0.10,  // Stripes_Width, // 
               1.00,  // Stripes_Length                                  
             ) //------------------------------------------------------------------//
    scale <10,10,10>*1
    rotate<0,0,0> 
    translate<0.00,0.00, -100.00>
}      
  



//-------------------------------------------------------------------------------------// 
//-------------------------------------------------------------------------------------// 
#declare Car_Body_Texture = 
         texture{ pigment{ color rgb<1,1,1>*1.2}
                //normal { radial sine_wave frequency 30 scale 0.25 }
                  finish { phong 1}
                 }
#declare Car_Top_Texture = 
         texture{ pigment{ color  rgb<1,1,1>*1.2}
                //normal { radial sine_wave frequency 30 scale 0.25 }
                  finish { phong 1}
                 }
#declare Car_Seat_Texture = 
          texture { pigment{ color rgb< 1, 0.90, 0.85>*1.2  }// very light brown  
                   normal { bumps 0.15 scale 0.05 }
                   finish { phong 1 reflection 0.00}
                 } // end of texture 
#declare Car_Inside_Texture=
          texture { pigment{ color rgb< 1, 0.87, 0.75>  }// very light brown  
                // normal { bumps 0.5 scale 0.05 }
                   finish { phong 1 reflection 0.00}
                 } // end of texture 

#declare Wheel_Rubber_Texture = 
         texture { pigment{ color rgb< 1, 1, 1>*0.15 } //  color Gray25
                   normal { bumps 0.5 scale 0.008 }
                   finish { phong 0.2 reflection 0.00}
                 } // end of texture 
#declare Wheel_Metal_Texture = 
         texture { Chrome_Metal
                   // pigment{ color rgb<1,0,0>} 
                    normal { bumps 0.5 scale 0.005 } 
                    finish { phong 1}
                 } // end of texture 
#declare Bumper_Metal_Texture = 
         texture { Polished_Chrome
                   // pigment{ color rgb<1,0,0>} 
                   finish {   phong 1}
                 } // end of texture 
#declare Chassis_Inside_Texture = 
         texture { pigment{ color rgb< 1, 1, 1>*0.45 } //  color Gray55
                // normal { bumps 0.5 scale 0.05 }
                   finish { phong 1 reflection 0.00}
                 } // end of texture 
//---------------------------------------------------------------------------------------
#include "Car_01.inc" 
//-------------------------------------------------------------------------------------// 
object{ Car_01( 30, //Front_Wheel_Angle, // 
                1, // Coupe_ON:  0= off(hard top); 1= coupé

                Car_Body_Texture, //
                Car_Top_Texture, //
                Car_Seat_Texture, //
                Car_Inside_Texture, //
                Wheel_Rubber_Texture,
                Wheel_Metal_Texture,
                Bumper_Metal_Texture,
                Chassis_Inside_Texture //
              ) //-------------------------------------------------- 
        scale<5,5,5>
        rotate<0,-0,0>
        translate<-30,0,20>} 
//-------------------------------------------------------------------------------------// 
//-------------------------------------------------------------------------------------// 
         

//-------------------------------------------------------------------------------------// 
//-------------------------------------------------------------------------------------// 
#declare Car_Body_Texture = 
         texture{ pigment{ color rgb<1,1,1>*1.2}
                //normal { radial sine_wave frequency 30 scale 0.25 }
                  finish { phong 1}
                 }
#declare Car_Top_Texture = 
         texture{ pigment{ color  rgb<1,1,1>*1.2}
                //normal { radial sine_wave frequency 30 scale 0.25 }
                  finish { phong 1}
                 }
#declare Car_Seat_Texture = 
          texture { pigment{ color rgb< 1, 0.90, 0.85>*1.2  }// very light brown  
                   normal { bumps 0.15 scale 0.05 }
                   finish { phong 1 reflection 0.00}
                 } // end of texture 
#declare Car_Inside_Texture=
          texture { pigment{ color rgb< 1, 0.87, 0.75>  }// very light brown  
                // normal { bumps 0.5 scale 0.05 }
                   finish { phong 1 reflection 0.00}
                 } // end of texture 

#declare Wheel_Rubber_Texture = 
         texture { pigment{ color rgb< 1, 1, 1>*0.15 } //  color Gray25
                   normal { bumps 0.5 scale 0.008 }
                   finish { phong 0.2 reflection 0.00}
                 } // end of texture 
#declare Wheel_Metal_Texture = 
         texture { Chrome_Metal
                   // pigment{ color rgb<1,0,0>} 
                    normal { bumps 0.5 scale 0.005 } 
                    finish { phong 1}
                 } // end of texture 
#declare Bumper_Metal_Texture = 
         texture { Polished_Chrome
                   // pigment{ color rgb<1,0,0>} 
                   finish {   phong 1}
                 } // end of texture 
#declare Chassis_Inside_Texture = 
         texture { pigment{ color rgb< 1, 1, 1>*0.45 } //  color Gray55
                // normal { bumps 0.5 scale 0.05 }
                   finish { phong 1 reflection 0.00}
                 } // end of texture 
//---------------------------------------------------------------------------------------
#include "Car_01.inc" 
//-------------------------------------------------------------------------------------// 
object{ Car_01( 30, //Front_Wheel_Angle, // 
                0, // Coupe_ON:  0= off(hard top); 1= coupé

                Car_Body_Texture, //
                Car_Top_Texture, //
                Car_Seat_Texture, //
                Car_Inside_Texture, //
                Wheel_Rubber_Texture,
                Wheel_Metal_Texture,
                Bumper_Metal_Texture,
                Chassis_Inside_Texture //
              ) //-------------------------------------------------- 
        scale<5,5,5>
        rotate<0,-90,0>
        translate<20,0,0>}        
        
        object{ Car_01( 30, //Front_Wheel_Angle, // 
                0, // Coupe_ON:  0= off(hard top); 1= coupé

                Car_Body_Texture, //
                Car_Top_Texture, //
                Car_Seat_Texture, //
                Car_Inside_Texture, //
                Wheel_Rubber_Texture,
                Wheel_Metal_Texture,
                Bumper_Metal_Texture,
                Chassis_Inside_Texture //
              ) //-------------------------------------------------- 
        scale<5,5,5>
        rotate<0,-90,0>
        translate<20,0,300>} 
//-------------------------------------------------------------------------------------// 
//-------------------------------------------------------------------------------------//          
         
       
     
#declare Wheel_Angle   =  -30; // ~  +/-60
#declare Truck_Texture =  

texture{ pigment{ color rgb<1,1,1>*1.1}
        finish { phong 1}
      }   

object{ Truck_11( Wheel_Angle, // Front wheel angle: ~  +/-60
              Truck_Texture 
            ) //---------------------------------------
    scale< 5,5,5>
    rotate<0,90,0> 
    translate<-10,0,-80>
  } 
            
union{            
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
    
    rotate <0,-90,0>          
    translate <-50,0,0>
}


union{            
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
    
    rotate <0,-90,0>          
    translate <-50,0,180>
}

union{            
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
    
    rotate <0,-90,0>          
    translate <-50,0,100>
}


//---------------------------------------------------------------------------------------
//----------------------------------------------------------------------------- textures
#declare Wall_Texture_Outside = 
      texture { pigment{ color White*1.1}
                normal { bumps 0.5 scale 0.005} 
                finish { phong 1}
              } // end of texture
//--------------------------------------------------------
#declare Wall_Texture_Inside = 
      texture { pigment{ color White*1.1}
                finish { phong 1}
              } // end of texture
//--------------------------------------------------------
#declare Roof_Texture = 
// layered texture!!!
      texture { pigment{ color Scarlet*1.3}
                normal { gradient z scallop_wave scale<1,1,0.15>} 
                finish { phong 1}
              } // end of texture
 
      texture { pigment{ gradient x 
                         color_map{[0.00 color Clear]
                                   [0.90 color Clear]
                                   [0.95 color White*0.1]
                                   [1.00 color White*0.1]}
                          scale 0.25}
                 finish { phong 1}
              } // end of texture

//--------------------------------------------------------
#declare Window_Texture = 
         texture{ pigment{ color rgb< 0.75, 0.5, 0.30>*0.35 } // brown  
                  // pigment{ color White*1.2}
                  finish { phong 0.1}}
//--------------------------------------------------------------------------------------- 
//---------------------------------------------------------------------------------------
#include "objs/House_2_0.inc" 
//-------------------------------------------------------------------------------------// 
object{ House_2_0(  2.80, // Half_House_Width_X, // >= 2.00
                    6.00, // Total_House_Width_Z,// >= 2.00
                    5.10, // House_Height_Y,     // >= 2.00
                    44,   // Roof___Angle, // ca. 10 ~ 60 degrees
                      
                    Wall_Texture_Outside
                    Wall_Texture_Inside 
                    Window_Texture                                                    
                    Roof_Texture
                   ) //----------------------------------------------------------------//
        scale <10,10,10>*1
        rotate<0,90,0> 
        translate<30.00,0.00, 0.00>}
//---------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------

             
             
             