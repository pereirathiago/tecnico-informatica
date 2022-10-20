#include "colors.inc"     
#include "woods.inc"                          
                          
camera {                  
    //olhar janela
    /*location <-12,10,13>
    look_at <15,5,-15.1>*/
    //olhar quadro
    location <12,10,13>
    look_at <-15,5,-15.1>
}                  

light_source {
    <0,19,0>
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
    
    // box buraco janela      
    box{
        <16,4,1.1>
        <-1,12,-10.1>
        pigment{color Brown}
    
    }                  
  
}
   
//tv
difference{
    box{
        <1,1,1>
        <-1,-1,-1>    
        scale<5.5,3.5,0.1>
        translate<0,10,-12.5>
    }   
    box{
        <1,1,1>
        <-1,-1,-1>    
        scale<5.2,3.2,0.01>
        translate<0,10,-12.5>        
        pigment{color Black}     
        //colocar imagem aqui
    }  
}        
      
//quadro      
difference{
    box{
        <1,1,1>
        <-1,-1,-1>    
        scale<0.1,3,4>
        translate<-12.5,10,-2>  
               texture{ T_Wood1     
                    normal { wood 0.5 scale 0.05}
                    finish { phong 1 } 
                    rotate<0,0, 0> scale 0.5
                  } // end of texture ------------------------
    }   
    box{
       <1,1,1>
       <-1,-1,-1>    
       scale<0,2.8,3.8>
       translate<-12.5,10,-2>        
       pigment{color Black}
    }
}           

//sofa
union {
    box{
       <1,1,1>
       <-1,-1,-1>     
       scale<9,3,0.5>  
       translate<0,3,0>  
       pigment{color Red}
    }   
    box{
       <1,1,1>
       <-1,-1,-1>     
       scale<9,1.5,2.5>  
       translate<0,2,-2>  
       pigment{color Red}
    } 
    box{
       <1,1,1>
       <-1,-1,-1>  
       scale<0.5,2,2.4>     
       translate<8.6,2,-2>  
       pigment{color Pink}  
       
    }     
    box{
       <1,1,1>
       <-1,-1,-1>  
       scale<0.5,2,2.4>     
       translate<-8.6,2,-2>  
       pigment{color Pink}  
       
    }   
    translate<0,0,7>
}


                


