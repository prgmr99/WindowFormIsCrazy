using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    internal class DBDiagramType : IPromptType
    {
        const string PROMPT_Template =
@"then translate below schema to PlantUML
```
{0}
```";
        public string Prompt { get; set; }

        public string Prompt_Template => PROMPT_Template;
        public ChatCompletionCreateRequest Options { get; }

        public DBDiagramType(string code)
        {

            Prompt = string.Format(PROMPT_Template, code);

            Options = new ChatCompletionCreateRequest()
            {
                Messages = new List<ChatMessage>

                {
                    ChatMessage.FromSystem(@"your task is to answer in a consistent style.

if you translate db schema then you should answer like below.
```@startuml

entity ""Classroom"" as classroom {
  +building: varchar(15)
  +room_number: varchar(7)
  +capacity: numeric(4,0)
  --
  +primary key (building, room_number)
}

entity ""Department"" as department {
  +dept_name: varchar(20)
  +building: varchar(15)
  +budget: numeric(12,2)
  --
  +primary key (dept_name)
}

entity ""Course"" as course {
  +course_id: varchar(8)
  +title: varchar(50)
  +dept_name: varchar(20)
  +credits: numeric(2,0)
  --
  +primary key (course_id)
  +foreign key (dept_name) references department on delete set null
}

entity ""Instructor"" as instructor {
  +ID: varchar(5)
  +name: varchar(20)
  +dept_name: varchar(20)
  +salary: numeric(8,2)
  --
  +primary key (ID)
  +foreign key (dept_name) references department on delete set null
}

entity ""Section"" as section {
  +course_id: varchar(8)
  +sec_id: varchar(8)
  +semester: varchar(6)
  +year: numeric(4,0)
  +building: varchar(15)
  +room_number: varchar(7)
  +time_slot_id: varchar(4)
  --
  +primary key (course_id, sec_id, semester, year)
  +foreign key (course_id) references course on delete cascade
  +foreign key (building, room_number) references classroom on delete set null
}

entity ""Teaches"" as teaches {
  +ID: varchar(5)
  +course_id: varchar(8)
  +sec_id: varchar(8)
  +semester: varchar(6)
  +year: numeric(4,0)
  --
  +primary key (ID, course_id, sec_id, semester, year)
  +foreign key (course_id, sec_id, semester, year) references section on delete cascade
  +foreign key (ID) references instructor on delete cascade
}

entity ""Student"" as student {
  +ID: varchar(5)
  +name: varchar(20)
  +dept_name: varchar(20)
  +tot_cred: numeric(3,0)
  --
  +primary key (ID)
  +foreign key (dept_name) references department on delete set null
}

entity ""Takes"" as takes {
  +ID: varchar(5)
  +course_id: varchar(8)
  +sec_id: varchar(8)
  +semester: varchar(6)
  +year: numeric(4,0)
  +grade: varchar(2)
  --
  +primary key (ID, course_id, sec_id, semester, year)
  +foreign key (course_id, sec_id, semester, year) references section on delete cascade
  +foreign key (ID) references student on delete cascade
}

entity ""Advisor"" as advisor {
  +s_ID: varchar(5)
  +i_ID: varchar(5)
  --
  +primary key (s_ID)
  +foreign key (i_ID) references instructor (ID) on delete set null
  +foreign key (s_ID) references student (ID) on delete cascade
}

entity ""Time_Slot"" as time_slot {
  +time_slot_id: varchar(4)
  +day: varchar(1)
  +start_hr: numeric(2)
  +start_min: numeric(2)
  +end_hr: numeric(2)
  +end_min: numeric(2)
  --
  +primary key (time_slot_id, day, start_hr, start_min)
}

entity ""Prereq"" as prereq {
  +course_id: varchar(8)
  +prereq_id: varchar(8)
  --
  +primary key (course_id, prereq_id)
  +foreign key (course_id) references course on delete cascade
  +foreign key (prereq_id) references course
}

classroom ""1"" -- ""0..*"" section
department ""1"" -- ""0..*"" course
department ""1"" -- ""0..*"" instructor
course ""1"" -- ""0..*"" section
instructor ""1"" -- ""0..*"" teaches
student ""1"" -- ""0..*"" takes
instructor ""0..1"" -- ""0..*"" advisor
time_slot ""1"" -- ""0..*"" section
course ""1"" -- ""0..*"" prereq

@enduml
```"),
                    ChatMessage.FromUser(Prompt)
                },
                Model = Models.ChatGpt3_5Turbo0301,
                MaxTokens = 2000,
                Temperature = 0,
                TopP = 1,
                FrequencyPenalty = 0,
                PresencePenalty = 0,

            };
        }
    }
}
