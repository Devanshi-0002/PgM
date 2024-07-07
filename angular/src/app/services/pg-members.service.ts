import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface PgMember {
  id: string;
  name: string;
  mobileNumber: string;
  email: string;
  rent: number;
  depositAmount: number;
  jobLocationId: string;
  permanentAddressId: string;
  dateOfJoining: Date;
  parentNumber: string;
  signature: string;
  pgId: string;
  extraProperties: string;
  concurrencyStamp: string;
  creationTime: Date;
  creatorId?: string;
  lastModificationTime?: Date;
  lastModifierId?: string;
  isDeleted: boolean;
  deleterId?: string;
  deletionTime?: Date;
}

@Injectable({
  providedIn: 'root'
})
export class PgMembersService {

  private apiUrl = 'https://localhost:44338/api/app/pg-member';

  constructor(private http: HttpClient) { }

  getPgMembers(): Observable<PgMember[]> {
    return this.http.get<PgMember[]>(this.apiUrl);
  }

  getPgMember(id: string): Observable<PgMember> {
    return this.http.get<PgMember>(`${this.apiUrl}/${id}`);
  }

  createPgMember(pgMember: PgMember): Observable<PgMember> {
    return this.http.post<PgMember>(this.apiUrl, pgMember);
  }

  updatePgMember(id: string, pgMember: PgMember): Observable<PgMember> {
    return this.http.put<PgMember>(`${this.apiUrl}/${id}`, pgMember);
  }

  deletePgMember(id: string): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
