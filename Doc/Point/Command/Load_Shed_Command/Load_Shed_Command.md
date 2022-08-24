[Point](../../Point.md) > [Command](../Command.md) > [Load_Shed_Command](#)
# Load_Shed_Command

**Display name:** Load Shed Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Shed_Command;1

---


## Child interfaces
* [Occupied_Load_Shed_Command](Occupied_Load_Shed_Command/Occupied_Load_Shed_Command.md)
* [Standby_Load_Shed_Command](Standby_Load_Shed_Command/Standby_Load_Shed_Command.md)
* [Unoccupied_Load_Shed_Command](Unoccupied_Load_Shed_Command/Unoccupied_Load_Shed_Command.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
