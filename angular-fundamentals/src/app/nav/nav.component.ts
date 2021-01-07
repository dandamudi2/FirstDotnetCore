import {  Component } from '@angular/core';

@Component({

    selector:'<nav-component></nav-component>',
    templateUrl:'./nav.component.html',
    styles:[
        `
        @media(max-width:1200px){
            #SearchBar{
                display:none;
            }
        }
        `
    ]
})

export class NavComponent{

}