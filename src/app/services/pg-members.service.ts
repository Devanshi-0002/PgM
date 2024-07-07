import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Address {
  addressLine1: string;
  addressLine2?: string;
  pincode: string;
  city: string;
  state: string;
}

export interface PgMember {
  id: string;
  fullName: string; // Ensure this matches the backend property name
  mobileNumber: string;
  email: string;
  rentAmount: number; // Corrected property name as per your backend
  depositedAmount: number; // Corrected property name if needed
  education: string;
  jobCollegeOtherOption: string;
  jobCollegeAddress: Address; // Adjust as per your backend structure
  dateOfJoining: Date;
  permanentAddress: Address; // Adjust as per your backend structure
  emergencyMobileNumber: string;
  pgId: string | null;
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
