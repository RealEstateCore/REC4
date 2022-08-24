[Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Load_Setpoint](../Load_Setpoint.md) > [Load_Shed_Setpoint](Load_Shed_Setpoint.md) > [Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint](#)
# Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint

**Display name:** Entering Medium Temperature Hot Water Temperature Load Shed Setp<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint;1

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
