import { Component } from '@angular/core';

import { lorem} from 'faker';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TypingGame';
  randomText: String=lorem.sentence();
  showMessage: boolean=false;
  checkedRandomText: string='';
  enteredText: string='';
  OnInput(value: string){
   
  
    this.enteredText =value;
  }


  compareText(letterText: string,enteredText: string){
     if(!enteredText)
     return "pending";

    return letterText === enteredText?'correct':'incorrect';
  }

}
