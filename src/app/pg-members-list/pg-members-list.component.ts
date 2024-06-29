import { Component, OnInit } from '@angular/core';
import { PgMembersService, PgMember } from '../services/pg-members.service';

@Component({
  selector: 'app-pg-members-list',
  standalone: true,
  imports: [],
  templateUrl: './pg-members-list.component.html',
  styleUrl: './pg-members-list.component.scss'
})
export class PgMembersListComponent implements OnInit {
  pgMembers: PgMember[] = [];

  constructor(private pgMembersService: PgMembersService) { }

  ngOnInit(): void {
    this.pgMembersService.getPgMembers().subscribe(data => {
      this.pgMembers = data;
    });
  }
}
