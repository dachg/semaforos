import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatTableDataSource } from '@angular/material/table';
import { ColorLigth } from '../models/color-ligth';
import { eColor } from '../models/e-color';
import { eGroups } from '../models/e-groups';
import { Traffic } from '../models/traffic';
import { TrafficService } from '../services/traffic.service';

@Component({
  selector: 'app-manager-component',
  templateUrl: './manager-component.component.html',
  styleUrls: ['./manager-component.component.css']
})
export class ManagerComponentComponent implements OnInit {

  color: ColorLigth = {};
  eColor = eColor;
  eGroup = eGroups;
  dataSource = new MatTableDataSource<Traffic>([]);
  groups = new FormControl();
  displayedColumns: string[] = ['idClient', 'lights', 'fails', 'idGroup'];
  

  constructor(private trafficService: TrafficService) {
    this.getTraffics();
  }

  ngOnInit(): void {
  }

  private getTraffics(): void {
    this.trafficService.getTraffics().subscribe(result => {
      this.dataSource.data = result;
    });
  }

}
