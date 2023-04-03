using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using LabTwo;
using static System.Reflection.Metadata.BlobBuilder;
using System.Diagnostics.Metrics;

namespace LabTwo
{
    public class MemberStore
    {

        public List<Member> members;

        public MemberStore()
        {
            members = new List<Member>();
        }
        public List<Member>Members
        {
            get { return this.members; }
        }

        public Member GetMemberByName(string name)
        {
            foreach (Member member in members)
            {
                if (member.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return member;
                }
            }
            return null;
        }

        public void AddMember(string id, string name)
        {
            Member member = new Member(id, name);
            members.Add(member);
            Console.WriteLine(" member added successfully");
        }

        public void RemoveMember()
        {
            Console.WriteLine("enter id :");
            string id = Console.ReadLine();
            Member memberToRemove = null;
            foreach (Member member in Members)
            {
                if (member.Id == id)
                {
                    memberToRemove = member;
                    break;
                }
            }

            if (memberToRemove != null)
            {
                Members.Remove(memberToRemove);
                Console.WriteLine("Member removed successfully.");
            }
            else
            {
                Console.WriteLine("Member not found.");
            }
        }
        public List<Member> GetMemberByID(string memberId)
        {
            List<Member> matchedMember = new List<Member>();
            foreach (Member member in Members)
            {
                if (member.Id == memberId)
                {
                    matchedMember.Add(member);
                }
            }

            if (matchedMember.Count == 0)
            {
                Console.WriteLine("No membber found with ID '{0}'", memberId);
            }

            return matchedMember;
        }


        public List<Member> ListMembers()
        {
            return members;
        }

        
    }

}


