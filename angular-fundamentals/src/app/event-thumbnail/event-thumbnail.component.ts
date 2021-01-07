import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-event-thumbnail',
  template: `
  
<hr>


<div class="card">
 <div class="card-header">
    <h3>{{event.name}}</h3>
 </div>
 <div class="card-body" [class.green]="event.time == '10:00 am'">
      <div>Price :\${{event.price}}</div>  
      <div>Date : {{event.date}}</div>  
      <div>Time : {{event.time}}</div>  
      <div>
         Address: {{event.location.address}}
      </div>
      <div>
         City: {{event.location.city}}
      </div>
 </div>
</div>

  `,
   styles: [
     `
       .green{background-color:#FFDD33 !important;}
    `
    
    ]
})
export class EventThumbnailComponent implements OnInit {

    @Input() event:any;
  constructor() { }

  ngOnInit() {
  }

}
