import { Component } from '@angular/core';
import { $ } from 'protractor';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PasswordGenerator';

  Password="";
  useLetters:boolean =false;
  useNumbers:boolean =false;
  useSpecielLetter:boolean =false;
  Length:number=0;
  specialCharacters:string="#$&*@";
  numbers:string="1238765";
  letters:string="abcdef";
  totalCharacters:string="";
  generatedPassword:string="";

  constructor(){
    this.generatedPassword ="";
  }

  getInputLength(length:number){
     this.Length =length;
  }

  getUseLetters(){
     this.useLetters =!this.useLetters;
     
  }

  getUseNumbers(){
    
    this.useNumbers =!this.useNumbers;
  }

  getUseSpecielCharacters(){
     
    this.useSpecielLetter=!this.useSpecielLetter;

  }

  assigngeneratePassword(){
    console.log(`
     UseLetters: ${this.useLetters}
     UseCharacters:${this.useNumbers}
     UseSpecielCharacters:${this.useSpecielLetter}
     `);
    this.totalCharacters ='';
      if(this.useLetters)
      {
        
        this.totalCharacters= this.letters;
      }
      console.log(this.totalCharacters);
      if(this.useNumbers)
      {
       
        this.totalCharacters += this.numbers;
      }
      console.log(this.totalCharacters);
      if(this.useSpecielLetter)
      {
       
        this.totalCharacters += this.specialCharacters;
      }
    
    this.generatedPassword='';
      for(var i=0;i<this.Length;i++)
      {
         const index= Math.floor(Math.random()*  this.totalCharacters.length);
             this.generatedPassword += this.totalCharacters[index];
      }

      this.Password= this.generatedPassword;
      
  }
}
