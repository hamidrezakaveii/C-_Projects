using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Demo6c_CreationComposantEInclusionInToolbox
{
    [DefaultProperty("nomContact")]
    public class ContactComponent : Component
    {
        //Propriétés communes
        private string m_nomContact;
        private string m_typeContact;
        private string m_telContact;

        //Propriété pour le nom du contact
        [Browsable(true), Category("Properties"), Description("Identifie le nom du contact")]
        public string NomContact
        {
            get { return m_nomContact; }
            set { m_nomContact = value; }
        }

        //Propriété pour le type du contact
        [Browsable(true), Category("Properties"), Description("Identifie le type du contact")]
        public string TypeContact
        {
            get { return m_typeContact; }
            set { m_typeContact = value; }
        }

        //Propriété pour le telephone du contact
        [Browsable(true), Category("Properties"), Description("Identifie le telephone du contact")]
        public string TelephoneContact
        {
            get { return m_telContact; }
            set { m_telContact = value; }
        }

        //Defaut constructeur
        public ContactComponent()
        {
            this.NomContact = "Une exemple de contact";
            this.TypeContact = "Professionnel";
            this.TelephoneContact = "514-555-5555";
        }

        //Defaut constructeur
        public ContactComponent(string nomContact, string typeContact, string telContact)
        {
            this.NomContact = nomContact;
            this.TypeContact = typeContact;
            this.TelephoneContact = telContact;
        }
    }
}
