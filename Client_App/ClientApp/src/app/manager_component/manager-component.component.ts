import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-manager-component',
  templateUrl: './manager-component.component.html',
  styleUrls: ['./manager-component.component.css']
})
export class ManagerComponentComponent implements OnInit {

  dataSource = [] = [{}];
  groups = new FormControl();
  displayedColumns: string[] = ['idClient', 'lights', 'fails', 'idGroup'];
  

  constructor() { }

  ngOnInit(): void {
  }

}
