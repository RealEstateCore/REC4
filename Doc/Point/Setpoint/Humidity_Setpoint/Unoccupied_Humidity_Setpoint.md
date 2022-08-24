[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Humidity_Setpoint](Humidity_Setpoint.md) > [Unoccupied_Humidity_Setpoint](#)
# Unoccupied_Humidity_Setpoint

**Display name:** Unoccupied Humidity Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Unoccupied_Humidity_Setpoint;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
