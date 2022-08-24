[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Load_Setpoint](#)
# Load_Setpoint

**Display name:** Load Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Setpoint;1

---


## Child interfaces
* [Load_Shed_Setpoint](Load_Shed_Setpoint/Load_Shed_Setpoint.md)

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
